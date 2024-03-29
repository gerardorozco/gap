﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GapApi.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Gap")]
	public partial class GapDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCita(Cita instance);
    partial void UpdateCita(Cita instance);
    partial void DeleteCita(Cita instance);
    partial void InsertPaciente(Paciente instance);
    partial void UpdatePaciente(Paciente instance);
    partial void DeletePaciente(Paciente instance);
    partial void InsertTipoCita(TipoCita instance);
    partial void UpdateTipoCita(TipoCita instance);
    partial void DeleteTipoCita(TipoCita instance);
    #endregion
		
		public GapDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["GapConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GapDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GapDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GapDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GapDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cita> Cita
		{
			get
			{
				return this.GetTable<Cita>();
			}
		}
		
		public System.Data.Linq.Table<Paciente> Paciente
		{
			get
			{
				return this.GetTable<Paciente>();
			}
		}
		
		public System.Data.Linq.Table<TipoCita> TipoCita
		{
			get
			{
				return this.GetTable<TipoCita>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cita")]
	public partial class Cita : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdCita;
		
		private int _TipoCita;
		
		private string _IdPaciente;
		
		private System.DateTime _Fecha;
		
		private System.TimeSpan _Hora;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCitaChanging(int value);
    partial void OnIdCitaChanged();
    partial void OnTipoCitaChanging(int value);
    partial void OnTipoCitaChanged();
    partial void OnIdPacienteChanging(string value);
    partial void OnIdPacienteChanged();
    partial void OnFechaChanging(System.DateTime value);
    partial void OnFechaChanged();
    partial void OnHoraChanging(System.TimeSpan value);
    partial void OnHoraChanged();
    #endregion
		
		public Cita()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCita", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdCita
		{
			get
			{
				return this._IdCita;
			}
			set
			{
				if ((this._IdCita != value))
				{
					this.OnIdCitaChanging(value);
					this.SendPropertyChanging();
					this._IdCita = value;
					this.SendPropertyChanged("IdCita");
					this.OnIdCitaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoCita", DbType="Int NOT NULL")]
		public int TipoCita
		{
			get
			{
				return this._TipoCita;
			}
			set
			{
				if ((this._TipoCita != value))
				{
					this.OnTipoCitaChanging(value);
					this.SendPropertyChanging();
					this._TipoCita = value;
					this.SendPropertyChanged("TipoCita");
					this.OnTipoCitaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPaciente", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string IdPaciente
		{
			get
			{
				return this._IdPaciente;
			}
			set
			{
				if ((this._IdPaciente != value))
				{
					this.OnIdPacienteChanging(value);
					this.SendPropertyChanging();
					this._IdPaciente = value;
					this.SendPropertyChanged("IdPaciente");
					this.OnIdPacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hora", DbType="Time NOT NULL")]
		public System.TimeSpan Hora
		{
			get
			{
				return this._Hora;
			}
			set
			{
				if ((this._Hora != value))
				{
					this.OnHoraChanging(value);
					this.SendPropertyChanging();
					this._Hora = value;
					this.SendPropertyChanged("Hora");
					this.OnHoraChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paciente")]
	public partial class Paciente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdPaciente;
		
		private string _NombrePaciente;
		
		private string _Telefono;
		
		private string _Direccion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPacienteChanging(string value);
    partial void OnIdPacienteChanged();
    partial void OnNombrePacienteChanging(string value);
    partial void OnNombrePacienteChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    #endregion
		
		public Paciente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPaciente", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdPaciente
		{
			get
			{
				return this._IdPaciente;
			}
			set
			{
				if ((this._IdPaciente != value))
				{
					this.OnIdPacienteChanging(value);
					this.SendPropertyChanging();
					this._IdPaciente = value;
					this.SendPropertyChanged("IdPaciente");
					this.OnIdPacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombrePaciente", DbType="VarChar(50)")]
		public string NombrePaciente
		{
			get
			{
				return this._NombrePaciente;
			}
			set
			{
				if ((this._NombrePaciente != value))
				{
					this.OnNombrePacienteChanging(value);
					this.SendPropertyChanging();
					this._NombrePaciente = value;
					this.SendPropertyChanged("NombrePaciente");
					this.OnNombrePacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TipoCita")]
	public partial class TipoCita : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdTipoCita;
		
		private string _TipoCita1;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTipoCitaChanging(int value);
    partial void OnIdTipoCitaChanged();
    partial void OnTipoCita1Changing(string value);
    partial void OnTipoCita1Changed();
    #endregion
		
		public TipoCita()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoCita", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdTipoCita
		{
			get
			{
				return this._IdTipoCita;
			}
			set
			{
				if ((this._IdTipoCita != value))
				{
					this.OnIdTipoCitaChanging(value);
					this.SendPropertyChanging();
					this._IdTipoCita = value;
					this.SendPropertyChanged("IdTipoCita");
					this.OnIdTipoCitaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TipoCita", Storage="_TipoCita1", DbType="VarChar(50)")]
		public string TipoCita1
		{
			get
			{
				return this._TipoCita1;
			}
			set
			{
				if ((this._TipoCita1 != value))
				{
					this.OnTipoCita1Changing(value);
					this.SendPropertyChanging();
					this._TipoCita1 = value;
					this.SendPropertyChanged("TipoCita1");
					this.OnTipoCita1Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
