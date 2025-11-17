#!/usr/bin/env bash
set -e

REPO_URL="https://github.com/NooqPL/Control-App.git"
APP_DIR="/home/pi/app"
APP_SUBDIR="PI"
SERVICE_NAME="controlapp"
USER_NAME="pi"





echo "=== Control-App Raspberry Pi installer ==="




# Update system
sudo apt update && sudo apt upgrade -y

# Install dependencies
sudo apt install -y git python3 python3-pip python3-venv pigpio mosquitto mosquitto-clients

# Enable pigpio (required for servos)
sudo systemctl enable --now pigpiod

# Clone or update repository
if [ -d "$APP_DIR" ]; then
  echo "Repository already exists. Updating..."
  sudo -u $USER_NAME git -C "$APP_DIR" fetch --all
  sudo -u $USER_NAME git -C "$APP_DIR" reset --hard origin/main
else
  echo "Cloning repository..."
  sudo -u $USER_NAME git clone "$REPO_URL" "$APP_DIR"
fi

cd "$APP_DIR/$APP_SUBDIR"

# Create virtual environment
if [ ! -d ".venv" ]; then
  sudo -u $USER_NAME python3 -m venv .venv
fi

# Install Python dependencies
sudo -u $USER_NAME .venv/bin/pip install --upgrade pip
sudo -u $USER_NAME .venv/bin/pip install -r requirements.txt

# Copy systemd services
sudo cp systemd/${SERVICE_NAME}.service /etc/systemd/system/
sudo cp systemd/update-repo.service /etc/systemd/system/
sudo cp systemd/update-repo.timer /etc/systemd/system/

sudo systemctl daemon-reload

# Enable persistent autostart
sudo systemctl enable --now ${SERVICE_NAME}.service
sudo systemctl enable --now update-repo.timer






echo "=== INSTALL COMPLETE ==="
echo "Application is running as systemd service: ${SERVICE_NAME}"
