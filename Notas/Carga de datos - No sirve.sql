USE [TPCClinica]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Horario] ([IdHorario], [Descripcion]) VALUES (1, N'10 a 11')


/****** Object:  Table [dbo].[Especialidad]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Nombre], [Descripcion]) VALUES (1, N'Ofmatologia', N'Cura ojos')


/****** Object:  Table [dbo].[Seguridad]    Script Date: 11/11/2020 00:24:01 ******/


/****** Object:  Table [dbo].[Persona]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Persona] ([DNI], [Nombre], [Apellido], [Domicilio], [FechaNacimiento], [Genero], [Estado]) VALUES (29156442, N'Gaston', N'Martinez', N'Alberti 312', CAST(0x78010B00 AS Date), N'Masculino', 1)
INSERT [dbo].[Persona] ([DNI], [Nombre], [Apellido], [Domicilio], [FechaNacimiento], [Genero], [Estado]) VALUES (38629407, N'Fernando', N'Brandan', N'Belgrano 894', CAST(0xD61C0B00 AS Date), N'Masculino', 1)
INSERT [dbo].[Persona] ([DNI], [Nombre], [Apellido], [Domicilio], [FechaNacimiento], [Genero], [Estado]) VALUES (40520341, N'Martina', N'Nuñez', N'Juan V Justo 213', CAST(0x3B210B00 AS Date), N'Femenino', 1)


/****** Object:  Table [dbo].[Perfil]    Script Date: 11/11/2020 00:24:01 ******/


/****** Object:  Table [dbo].[Paciente]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Paciente] ([CodigoPaciente], [DNI], [FechaInscripcion], [Email]) VALUES (N'MARNUÑ40', 40520341, CAST(0x47400B00 AS Date), N'marnuñez@gmail.com')


/****** Object:  Table [dbo].[Medico]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Medico] ([LegajoMedico], [DNI], [FechaIngreso], [Especialidad]) VALUES (N'GASMAR', 29156442, CAST(0x7E220B00 AS Date), 1)


/****** Object:  Table [dbo].[Disponibilidad]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Disponibilidad] ([IdDisponibilidad], [Horario], [FechaTurno], [Estado]) VALUES (1, 1, CAST(0xCF410B00 AS Date), 1)


/****** Object:  Table [dbo].[Usuario]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Usuario] ([LegajoUsuario], [DNI], [FechaIngreso], [Seguridad], [Perfil]) VALUES (N'FERBRA38', 38629407, CAST(0x2D320B00 AS Date), NULL, NULL)


/****** Object:  Table [dbo].[Turno]    Script Date: 11/11/2020 00:24:01 ******/
INSERT [dbo].[Turno] ([IdTurno], [Disponibilidad], [Medico], [Paciente], [Motivo], [Estado]) VALUES (1, 1, N'GASMAR', N'MARNUÑ40', N'Consulta', 1)


/****** Object:  Table [dbo].[FichaMedica]    Script Date: 11/11/2020 00:24:01 ******/
