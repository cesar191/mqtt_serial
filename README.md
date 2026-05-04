# Información del proyecto
Este proyecto esta implementado para poder realizar practicas de control PID de manera IOT al usar MQTT como servidor, el cual se comunica con una tarjeta ESP32 para el respectivo control.
## Usos del software correcto
para que el software funcione correctamente se debe tener lo siguiente
- Instalado Mosquito (para el Mqtt local)
- Los topicos que manejen en la ESP32 serian los siguientes
  - para enviar informacióm:
    - test/sensor/temperatura1
    - test/sensor/temperatura2
    - test/sensor/corrienteQ1
    - test/sensor/corrienteQ2
    - test/sensor/tiempo
  - para recibir la información:
    - test/datos/pwm1
    - test/datos/pwm2
    - test/datos/led1
    - test/datos/led2
    - test/datos/ventilador1
    - test/datos/ventilador2
## Codigo de arduino
el codigo de arduino se puede reviar en el siguiente repositorio: https://github.com/cesar191/CodigoEsp32Mqtt.git

