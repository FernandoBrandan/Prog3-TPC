
create database TPCClinica
go
use TPCClinica
go
/** TABLAS ESTANDAR **/
create table Especialidad
(
	IdEspecialidad bigint not null primary key identity(1,1),
	Nombre varchar(50) not null, 
	Descripcion varchar(100) not null
)
go
create table Horario
(
	IdHorario bigint not null primary key identity(1,1),
	Descripcion varchar(100) not null
)
go
create table Seguridad
(
	IdSeguridad bigint not null primary key identity(1,1),
	Contraseña varbinary(255), 
	UltimaConexion date
)
go
create table Perfil
(
	IdPerfil bigint not null primary key identity(1,1),
	Rol varchar(100) not null
)
go
/*create table --Genero 			SE REEMPLAZA POR CHECKBOX LIST
(
	idGenero int not null primary key identity(1,1),
	Descripcion varchar(100) not null check(Descripcion = 'Femenino' or Descripcion = 'Masculino')
	/*check(Descripcion = 'Femenino' or Descripcion = 'Masculino')*/
)*/
/** TABLAS PRINCIPALES **/
create table Disponibilidad
(
	IdDisponibilidad bigint not null primary key identity(1,1),
	Horario bigint not null foreign key references Horario(IdHorario),
	FechaTurno date not null, 
	Estado varchar(50) not null
)
go
create table Persona
(
	DNI bigint not null primary key,
	Nombre varchar(100) not null,
	Apellido varchar(100) not null,
	Domicilio varchar(100) not null,
	FechaNacimiento date not null,
	Genero varchar(10) not null,
	Estado bit not null
)
go
create table Usuario
(
	LegajoUsuario varchar(10) not null primary key,
	DNI bigint not null unique foreign key references Persona(DNI),
	FechaIngreso date not null, 
	Seguridad bigint null foreign key references Seguridad(IdSeguridad),
	Perfil bigint null foreign key references Perfil(IdPerfil)	
)
go
create table Medico
(
	LegajoMedico varchar(10) not null primary key,
	DNI bigint not null unique foreign key references Persona(DNI),
	FechaIngreso date not null, 
	Especialidad bigint not null foreign key references Especialidad(IdEspecialidad)
)
create table Paciente
(
	CodigoPaciente varchar(10) not null primary key,
	DNI bigint not null unique foreign key references Persona(DNI),
	FechaInscripcion date not null,
	Email varchar(100) not null	
)
go
create table Turno
(
	IdTurno bigint not null primary key identity(1,10),
	Disponibilidad bigint not null foreign key references Disponibilidad(IdDisponibilidad),
	Medico varchar(10) not null foreign key references Medico(LegajoMedico),
	Paciente varchar(10) not null foreign key references Paciente(CodigoPaciente),
	Motivo varchar(500) not null,
	Estado varchar (50) not null
)
go
/** TABLAS REPORTE **/
create table FichaMedica
(
	IdFicha bigint not null primary key identity(1,10),
	Turno bigint not null unique foreign key references Turno(IdTurno),
	Diagnostico varchar(1000) not null
)

Select *from Paciente
Select *from Usuario
Select *from Persona