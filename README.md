# Laboratorio de Control PID de Temperatura sobre IoT (MQTT & ESP32)

Este proyecto implementa un software de escritorio intuitivo desarrollado en **C# y .NET (Windows Forms)** diseñado para realizar prácticas de control PID en entornos IoT. La aplicación actúa como una interfaz HMI centralizada que se comunica de manera asíncrona mediante el protocolo **MQTT** con una tarjeta de desarrollo **ESP32**, encargada de la adquisición de señales de sensores y de la ejecución física de las variables de control.

---

## 🚀 Características Clave

- **Control Multivariable:** Soporte independiente para la adquisición y control en tiempo real de múltiples plantas (G(s)).
- **Cálculo de Algorítmo PID Digital:** Implementación matemática nativa en C# de las ecuaciones en diferencias para las acciones de control P, PI y PID con saturación de PWM (anti-windup básico).
- **Arquitectura de Software Dinámica:** Navegación optimizada mediante el uso de formularios contenedores utilizando métodos genéricos (`<T> where T : Form, new()`), previniendo fugas de memoria y redundancia visual en el ciclo de vida de la aplicación.

---

## 🛠️ Requisitos del Sistema y Prerrequisitos

Para que el ecosistema de software y hardware funcione correctamente, asegúrate de contar con los siguientes elementos:

1. **Broker MQTT Local:** Es necesario tener instalado y configurado **Eclipse Mosquitto** en tu red local. Puedes seguir la [Guía de Instalación de Mosquitto en Video](https://youtu.be/G_Xj6II8waY?si=RZoSo-mNR9eyXzGo) para ponerlo en marcha rápidamente.
2. **Entorno de Ejecución:** .NET Framework compatible con Windows Forms (desarrollado en Visual Studio Community).
3. **Firmware de la Tarjeta:** El código fuente que debe programarse en la ESP32 se encuentra alojado en este repositorio oficial: 
   👉 [Repositorio de Código ESP32 MQTT](https://github.com/cesar191/CodigoEsp32Mqtt.git)

---

## 📡 Matriz de Tópicos MQTT

La comunicación entre el HMI en C# y la tarjeta ESP32 se gestiona de manera estricta bajo la siguiente topología de tópicos:

| Dirección (Perspectiva ESP32) | Tópico MQTT | Descripción del Dato |
| :--- | :--- | :--- |
| **Envía (Publica)** | `test/sensor/temperatura1` | Lectura del sensor de temperatura 1 |
| **Envía (Publica)** | `test/sensor/temperatura2` | Lectura del sensor de temperatura 2 |
| **Envía (Publica)** | `test/sensor/corrienteQ1` | Monitoreo de corriente en actuador Q1 |
| **Envía (Publica)** | `test/sensor/corrienteQ2` | Monitoreo de corriente en actuador Q2 |
| **Envía (Publica)** | `test/sensor/tiempo` | Sincronización o estampa de tiempo del sistema |
| **Recibe (Suscribe)** | `test/datos/pwm1` | Señal de control manipulada para Q1 |
| **Recibe (Suscribe)** | `test/datos/pwm2` | Señal de control manipulada para Q2 |
| **Recibe (Suscribe)** | `test/datos/led1` | Estado / Activación de indicador LED 1 |
| **Recibe (Suscribe)** | `test/datos/led2` | Estado / Activación de indicador LED 2 |
| **Recibe (Suscribe)** | `test/datos/ventilador1` | Estado de activación del ventilador 1 |
| **Recibe (Suscribe)** | `test/datos/ventilador2` | Estado de activación del ventilador 2 |

---

## 🏛️ Estructura y Funcionamiento del Software

El HMI utiliza un patrón de diseño modular basado en un contenedor unificado. El formulario raíz de la aplicación es `Form1.cs` (`pantalla_principal`), el cual incrusta dinámicamente las subventanas operacionales dentro de un panel central, garantizando una interfaz de usuario limpia y de pantalla única.

Módulos principales del sistema:
- **Conexión:** Interfaz dedicada a configurar los parámetros de red del Broker MQTT (IP, puerto y credenciales) y establecer el enlace asíncrono inicial.
- **Adquisición (`adquirir_Q1` / `Adquirir_Q2`):** Pantallas destinadas a la visualización y registro gráfico de las variables físicas que provienen de los sensores en tiempo real, en respuesta al PWM que se suministre.
- **Control (`control_Q1` / `control_Q1Q2`):** Paneles de sintonización analógica donde el operador puede ingresar las constantes del controlador ($K_p$, $K_i$, $K_d$ y tiempo de muestreo $T_s$) para activar el bucle cerrado sobre los actuadores térmicos.

---

## 🛠️ Estructura del Código Fuente

```text
mqtt_serial/
├── funciones/
│   ├── ControlPID.cs       # Algoritmos matemáticos y lógica de validación PID
│   └── VariablesControl.cs # Estado global de las variables y telemetría de conexión
├── ventanas/               # Subformularios embebidos dinámicamente
│   ├── conexion.cs
│   ├── adquirir_Q1.cs
│   ├── Adquirir_Q2.cs
│   ├── control_Q1.cs
│   └── control_Q1Q2.cs
├── Form1.cs                # Formulario contenedor principal HMI (Manejador de vistas)
└── Program.cs              # Punto de entrada de la aplicación .NET
