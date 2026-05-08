# Información del proyecto
Este proyecto esta implementado para poder realizar practicas de control PID de manera IOT al usar MQTT como servidor, el cual se comunica con una tarjeta ESP32 para el respectivo control.
## Usos del software correcto
para que el software funcione correctamente se debe tener lo siguiente
- Instalado Mosquito (para el Mqtt local) seguir la guía de este video https://youtu.be/G_Xj6II8waY?si=RZoSo-mNR9eyXzGo
- Los topicos que manejen en la ESP32 serian los siguientes
  | Envia    | Recibe         |
  | ------------- |:-------------:|
  | test/sensor/temperatura1| test/datos/pwm1|
  | test/sensor/temperatura2| test/datos/pwm2|
  | test/sensor/corrienteQ1 | test/datos/led1    |
  | test/sensor/corrienteQ2 | test/datos/led2|
  |test/sensor/tiempo       |test/datos/ventilador1|
  ||test/datos/ventilador2|
## Codigo de arduino
el codigo de arduino se puede reviar en el siguiente repositorio: https://github.com/cesar191/CodigoEsp32Mqtt.git
## Funcionamiento del Software
El Software tiene al [Form1](Form1.cs) de Raiz ya que es la ventana que llama las ventanas en un panel como las ventanas de conexión, adquirir y control
 -Conexion: es la ventana donde se selecciona a que broker se piensa conectar en este caso tiene


