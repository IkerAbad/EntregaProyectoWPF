# EntregaProyectoWPF

Proyecto de entrega de WPF del ciclo de DAM (noviembre de 2022). Es una aplicación de escritorio con el patrón MVVM, con una pantalla de inicio y tres secciones: trabajadores, ventas y almacén (artículos con su identificador, autor, título, stock e IVA).

## Qué hay

- `EntregaProyectoWPF/View` con las ventanas `MainWindow`, `Inicio`, `Trabajador`, `Ventas` y `Almacen`.
- `EntregaProyectoWPF/Model` con las clases `Trabajador`, `Ventas` y `Almacen`.
- `EntregaProyectoWPF/ViewModel` con un ViewModel por sección, con su comando de actualización.

## Cómo abrirlo

Necesita Windows y Visual Studio con la carga de trabajo de escritorio de .NET. Abre `EntregaProyectoWPF.sln` y ejecútalo. No lo he compilado desde el entorno en el que escribí este README, así que no puedo garantizar que compile sin tocar nada.

---

# EntregaProyectoWPF (English)

WPF hand-in project from my DAM vocational course (November 2022). A desktop application using the MVVM pattern, with a start screen and three sections: workers, sales and warehouse (items with id, author, title, stock and VAT).

## What's inside

- `EntregaProyectoWPF/View` with the `MainWindow`, `Inicio`, `Trabajador`, `Ventas` and `Almacen` windows.
- `EntregaProyectoWPF/Model` with the `Trabajador`, `Ventas` and `Almacen` classes.
- `EntregaProyectoWPF/ViewModel` with one ViewModel per section, each with its own update command.

## Opening it

It needs Windows and Visual Studio with the .NET desktop workload. Open `EntregaProyectoWPF.sln` and run it. I could not compile it in the environment where I wrote this README, so I can't guarantee it builds untouched.
