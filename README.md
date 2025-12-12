# Simulador de Cafetería – Proyecto con Patrones de Diseño y Arquitectura MVC

Este proyecto es un simulador donde el usuario puede armar su propio café agregando los ingredientes que desee. El objetivo principal fue aplicar varios patrones de diseño y organizar el programa con la arquitectura MVC para mantener un código más claro, ordenado y fácil de mantener.

---

## Funciones principales

- Crear un café base.
- Agregar ingredientes como leche, azúcar, canela o caramelo.
- Mostrar la descripción final del café.
- Calcular el total en pesos.
- Convertir el precio a dólares mediante un adaptador.
- Controlar el flujo del café mediante estados.
- Construcción paso por paso utilizando el patrón Builder.
- Separación del programa en Model, View y Controller (MVC).

---

## Patrones de diseño aplicados

### 1. Decorator (Decorador)
Se utiliza para agregar ingredientes al café sin modificar la clase base.  
Clases: CafeConLeche, CafeConAzucar, CafeConCaramelo, CafeConCanela.

### 2. Builder
Permite construir el café paso a paso conforme el usuario elige los ingredientes.  
Clase: CafeBuilder.

### 3. State (Estado)
Administra las diferentes etapas del proceso del café:  
- EstadoInicial  
- EstadoPersonalizado  
- EstadoPrecioConvertido  

Clase principal: CafeContexto.

### 4. Adapter (Adaptador)
Convierte el precio de pesos a dólares sin mezclar esa lógica con el resto del programa.  
Clases: ISistemaPrecios, AdaptadorSistemaPrecios.

---

## Arquitectura MVC

El proyecto está organizado en tres partes principales:

### Model
Contiene toda la lógica del programa, incluyendo:
- Decorador  
- Builder  
- Adaptador  
- State  
- Interfaces y clases base del café  

### View
Muestra la información al usuario.  
Clase: CafeView.

### Controller
Controla el flujo del programa.  
Clase: CafeController.

El archivo Program.cs es el punto de inicio de la aplicación.

---

## Estructura del proyecto

---CafeteriaExamen
│
├── model
│ ├── ICafe.cs
│ ├── CafeSimple.cs
│ ├── DecoradorCafe.cs
│ ├── CafeConLeche.cs
│ ├── CafeConAzucar.cs
│ ├── CafeConCaramelo.cs
│ ├── CafeConCanela.cs
│ ├── CafeBuilder.cs
│ ├── ICafeEstado.cs
│ ├── CafeContexto.cs
│ ├── EstadoInicial.cs
│ ├── EstadoPersonalizado.cs
│ ├── EstadoPrecioConvertido.cs
│ ├── ISistemaPrecios.cs
│ └── AdaptadorSistemaPrecios.cs
│
├── vista
│ └── CafeView.cs
│
├── controlar
│ └── CafeController.cs
│
└── Program.cs

## Ejecución del programa

Ejecutar el proyecto desde Visual Studio.  
El programa muestra un menú donde se puede:

1. Crear un café.
2. Agregar ingredientes.
3. Finalizar el pedido.
4. Ver el total en pesos y dólares.

---

## Diagrama UML

El diagrama UML fue generado en Lucidchart con base en las clases y sus relaciones.

---

## Conclusión

Este proyecto ayudó a entender mejor la función de los patrones de diseño y la importancia de organizar un sistema con MVC. Cada patrón aporta una solución clara a un problema específico, logrando un código más ordenado, flexible y fácil de modificar.


