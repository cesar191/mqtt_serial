# Información del proyecto
Este proyecto esta implementado para poder realizar practicas de control PID de manera IOT al usar MQTT como servidor, el cual se comunica con una tarjeta ESP32
## Usos del software correcto
para que el software funcione correctament se debe tener lo siguiente
- Instalado Mosquito (para el Mqtt local)
- Los topicos que manejen en la ESP32 serian los siguientes
--test/sensor/temperatura1
--test/sensor/temperatura2
--test/sensor/corrienteQ1
--const char* data_IQ2="test/sensor/corrienteQ2";
--const char* data_time="test/sensor/tiempo";

--const char* msg_pwm1="test/datos/pwm1";
--const char* msg_pwm2="test/datos/pwm2";
--const char* msg_led1="test/datos/led1";
--const char* msg_led2="test/datos/led2";
--const char* msg_ventilador1="test/datos/ventilador1";
--const char* msg_ventilador2="test/datos/ventilador2";
