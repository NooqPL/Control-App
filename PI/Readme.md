
# Rasbery Pi Program

This program is for establising comunication with the control-app ( CP )
 it needs to 
- Be able to comunicate on ethernet port
- Detect sensors sends the telemetry to the CP
- To recive data from CP to operate the servos 

## How to set up 
### tested on Pi zero 2 W, Pi os 32 bit lite
set up login to controlstation
set up your password

afert login in to the device using ssh
run this command 
curl -sSL https://raw.githubusercontent.com/NooqPL/Control-App/main/PI/install.sh | bash
