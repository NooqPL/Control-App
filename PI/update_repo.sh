#!/usr/bin/env bash
cd /home/controlstation/app || exit 1

git fetch --all
LOCAL=$(git rev-parse HEAD)
REMOTE=$(git rev-parse origin/main)

if [ "$LOCAL" != "$REMOTE" ]; then
    echo "New version detected. Updating..."
    git reset --hard origin/main
    sudo systemctl restart controlapp.service
    echo "Restarted at $(date)"
else
    echo "No updates available."
fi
