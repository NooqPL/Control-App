def process_command(cmd, hw):
    try:
        parts = cmd.split(":")

        match parts[0]:
            case "PING":
                return "PONG"

            case "SERVO":
                sid = int(parts[1])
                val = float(parts[2])
                hw.set_servo(sid, val)
                return "OK"

            case "SENSOR":
                sid = int(parts[1])
                val = hw.read_sensor(sid)
                return str(val)

            case _:
                return "ERR:UNKNOWN"

    except Exception as e:
        return f"ERR:{e}"
