# 🚀 Rocket Test Stand Control System

A Windows Forms application for managing and monitoring a **liquid-fuel engine test stand** — designed for educational and experimental purposes. This application provides real-time telemetry, manual and automatic valve control, communication over serial port or network, and expandable telemetry logging.

![Screenshot](./screenshot.png) <!-- Dodaj screenshot, jeśli chcesz -->

---

## ✨ Features

- ✅ **Manual control** of valves (open/close toggle)
- ✅ **Visual indicators** for valve states (green/red)
- ✅ **Pressure & fuel level meters** (vertical progress bars)
- ✅ **Serial communication** with COM port or Raspberry Pi via TCP/MQTT
- ✅ **Telemetry logging** (timestamped sensor data)
- ✅ **Startup splash screen** with branding
- ✅ **Two operation modes**:
  - Test mode (manual)
  - Automatic mode with programmable sequences
- ✅ **Custom sequence editor** (coming soon)
- 🔒 Designed with safety and clarity in mind

---

## 💻 Technologies Used

- `.NET Framework` / `C#`
- Windows Forms (WinForms)
- `System.IO.Ports` for serial port communication
- `FakePort.cs` for simulation and offline development
- Optional: MQTT / TCP (Node-RED / Raspberry Pi integration)

---

## 🧪 Use Case: University Rocket Test Stand

This project is being developed for academic purposes as part of a student research group or thesis work. It allows for safe, automated and visual control over fuel valves, pressure readings, and ignition sequences of a small rocket engine test stand.

---

## 🧭 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/rocket-test-stand.git
