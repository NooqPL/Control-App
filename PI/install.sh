#!/usr/bin/env bash
set -e

REPO_URL="https://github.com/NooqPL/Control-App.git"
APP_DIR="/home/controlstation/app"
APP_SUBDIR="PI"
SERVICE_NAME="controlapp"
USER_NAME="controlstation"


RED="\033[0;31m"
GREEN="\033[0;32m"
YELLOW="\033[1;33m"
NC="\033[0m" # No Color



echo "=== Control-App Raspberry Pi installer ==="

# Function to run commands and report errors
run() {
    echo ">>> Running: $*"
    if ! "$@"; then
        echo "!!! ERROR: Command failed: $*"
    fi
}

# Update system
run sudo apt update
run sudo apt upgrade -y

# Install dependencies
run sudo apt install -y git python3 python3-pip python3-venv pigpio mosquitto mosquitto-clients

# Enable pigpio
run sudo systemctl enable --now pigpiod

# Clone or update repository
if [ -d "$APP_DIR" ]; then
    echo "Repository already exists. Updating..."
    run sudo -u $USER_NAME git -C "$APP_DIR" fetch --all
    run sudo -u $USER_NAME git -C "$APP_DIR" reset --hard origin/main
else
    echo "Cloning repository..."
    run sudo -u $USER_NAME git clone "$REPO_URL" "$APP_DIR"
fi

cd "$APP_DIR/$APP_SUBDIR"

# Create virtual environment
if [ ! -d ".venv" ]; then
    run sudo -u $USER_NAME python3 -m venv .venv
fi

# Install Python dependencies
run sudo -u $USER_NAME .venv/bin/pip install --upgrade pip
run sudo -u $USER_NAME .venv/bin/pip install -r requirements.txt

# Copy systemd services
run sudo cp systemd/${SERVICE_NAME}.service /etc/systemd/system/
run sudo cp systemd/update-repo.service /etc/systemd/system/
run sudo cp systemd/update-repo.timer /etc/systemd/system/

run sudo systemctl daemon-reload

# Enable services
run sudo systemctl enable --now ${SERVICE_NAME}.service
run sudo systemctl enable --now update-repo.timer

echo "=== INSTALL COMPLETE ==="
echo " " 

# Final checklist
echo "=== FINAL CHECKLIST ==="
for cmd in git python3 pip3 pigpiod mosquitto; do
    if command -v $cmd >/dev/null 2>&1; then
        echo "[${GREEN}OK${NC}] $cmd installed"
    else
        echo "[${RED}MISSING${NC}] $cmd not found"
    fi
done

for svc in pigpiod ${SERVICE_NAME} update-repo.timer; do
    if systemctl is-active --quiet $svc; then
        echo "[${GREEN}RUNNING${NC}] $svc service active"
    else
        echo "[${RED}STOPPED${NC}] $svc service not running"
    fi
done
echo " " 
echo "Installation finished. Check above for any errors or missing components."
echo " "