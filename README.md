# 📘 Proyecto: Registro del cliente en C#


## 📌 Descripción
Este programa permite al usuario **registrar clientes** mediante un formulario con validación de campos y un **ListBox** que acumula los clientes registrados.  
Su objetivo es garantizar que los datos ingresados (Nombre, Teléfono y Correo) sean obligatorios y se almacenen de manera dinámica en la aplicación.

---

## 🚀 Funcionalidades
- Entrada de datos mediante campos de texto (**Nombre, Teléfono, Correo**).
- Validación de campos obligatorios (no permite guardar si falta algún dato).
- Almacenamiento dinámico en una lista de clientes.
- Limpieza automática de los campos tras guardar un registro.

---

## 🛠️ Tecnologías utilizadas
- Lenguaje: **C#**
- Entorno: **Aplicación de Windows Forms**

---

## 📂 Estructura del código
El programa se organiza de la siguiente manera:

- **Espacio de Nombre:** `Registro_Cliente`  
- **Clase principal:** `Form1`  
- **Evento:** `btn_Guardar_Click`  
  - Valida que los campos no estén vacíos.  
  - Muestra un mensaje de advertencia si falta algún campo por llenar.  
  - Agrega el nuevo cliente a la lista.  
  - Limpia los campos para nueva entrada de datos.  

---
## 🖼️ Captura de Ejecución
<img width="1266" height="768" alt="Captura de pantalla 2026-07-31 020440" src="https://github.com/user-attachments/assets/0444224b-f48f-4b69-aa76-e1b8d72d1230" />

<img width="1260" height="782" alt="Captura de pantalla 2026-07-31 020544" src="https://github.com/user-attachments/assets/7c156143-2575-4ce5-affd-4324d6568e88" />


