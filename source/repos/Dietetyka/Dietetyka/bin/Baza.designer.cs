﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dietetyka
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Baza")]
	public partial class BazaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDanie(Danie instance);
    partial void UpdateDanie(Danie instance);
    partial void DeleteDanie(Danie instance);
    partial void InsertKonto(Konto instance);
    partial void UpdateKonto(Konto instance);
    partial void DeleteKonto(Konto instance);
    partial void InsertProdukt_spozywczy(Produkt_spozywczy instance);
    partial void UpdateProdukt_spozywczy(Produkt_spozywczy instance);
    partial void DeleteProdukt_spozywczy(Produkt_spozywczy instance);
    partial void InsertMenu(Menu instance);
    partial void UpdateMenu(Menu instance);
    partial void DeleteMenu(Menu instance);
    partial void InsertSkladnik(Skladnik instance);
    partial void UpdateSkladnik(Skladnik instance);
    partial void DeleteSkladnik(Skladnik instance);
    #endregion
		
		public BazaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BazaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Danie> Danies
		{
			get
			{
				return this.GetTable<Danie>();
			}
		}
		
		public System.Data.Linq.Table<Konto> Kontos
		{
			get
			{
				return this.GetTable<Konto>();
			}
		}
		
		public System.Data.Linq.Table<Produkt_spozywczy> Produkt_spozywczies
		{
			get
			{
				return this.GetTable<Produkt_spozywczy>();
			}
		}
		
		public System.Data.Linq.Table<Menu> Menu
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
		
		public System.Data.Linq.Table<Skladnik> Skladniks
		{
			get
			{
				return this.GetTable<Skladnik>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Danie")]
	public partial class Danie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nazwa;
		
		private string _kategoria;
		
		private string _przepis;
		
		private EntitySet<Menu> _Menu;
		
		private EntitySet<Skladnik> _Skladniks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnazwaChanging(string value);
    partial void OnnazwaChanged();
    partial void OnkategoriaChanging(string value);
    partial void OnkategoriaChanged();
    partial void OnprzepisChanging(string value);
    partial void OnprzepisChanged();
    #endregion
		
		public Danie()
		{
			this._Menu = new EntitySet<Menu>(new Action<Menu>(this.attach_Menu), new Action<Menu>(this.detach_Menu));
			this._Skladniks = new EntitySet<Skladnik>(new Action<Skladnik>(this.attach_Skladniks), new Action<Skladnik>(this.detach_Skladniks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nazwa
		{
			get
			{
				return this._nazwa;
			}
			set
			{
				if ((this._nazwa != value))
				{
					this.OnnazwaChanging(value);
					this.SendPropertyChanging();
					this._nazwa = value;
					this.SendPropertyChanged("nazwa");
					this.OnnazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kategoria", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string kategoria
		{
			get
			{
				return this._kategoria;
			}
			set
			{
				if ((this._kategoria != value))
				{
					this.OnkategoriaChanging(value);
					this.SendPropertyChanging();
					this._kategoria = value;
					this.SendPropertyChanged("kategoria");
					this.OnkategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_przepis", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string przepis
		{
			get
			{
				return this._przepis;
			}
			set
			{
				if ((this._przepis != value))
				{
					this.OnprzepisChanging(value);
					this.SendPropertyChanging();
					this._przepis = value;
					this.SendPropertyChanged("przepis");
					this.OnprzepisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Danie_Menu", Storage="_Menu", ThisKey="Id", OtherKey="Id_dania")]
		public EntitySet<Menu> Menu
		{
			get
			{
				return this._Menu;
			}
			set
			{
				this._Menu.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Danie_Skladnik", Storage="_Skladniks", ThisKey="Id", OtherKey="Id_dania")]
		public EntitySet<Skladnik> Skladniks
		{
			get
			{
				return this._Skladniks;
			}
			set
			{
				this._Skladniks.Assign(value);
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
		
		private void attach_Menu(Menu entity)
		{
			this.SendPropertyChanging();
			entity.Danie = this;
		}
		
		private void detach_Menu(Menu entity)
		{
			this.SendPropertyChanging();
			entity.Danie = null;
		}
		
		private void attach_Skladniks(Skladnik entity)
		{
			this.SendPropertyChanging();
			entity.Danie = this;
		}
		
		private void detach_Skladniks(Skladnik entity)
		{
			this.SendPropertyChanging();
			entity.Danie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Konto")]
	public partial class Konto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _imie;
		
		private string _nazwisko;
		
		private char _rodzaj;
		
		private string _login;
		
		private string _haslo;
		
		private string _telefon;
		
		private EntitySet<Menu> _Menu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void OnrodzajChanging(char value);
    partial void OnrodzajChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnhasloChanging(string value);
    partial void OnhasloChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    #endregion
		
		public Konto()
		{
			this._Menu = new EntitySet<Menu>(new Action<Menu>(this.attach_Menu), new Action<Menu>(this.detach_Menu));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rodzaj", DbType="Char(1) NOT NULL")]
		public char rodzaj
		{
			get
			{
				return this._rodzaj;
			}
			set
			{
				if ((this._rodzaj != value))
				{
					this.OnrodzajChanging(value);
					this.SendPropertyChanging();
					this._rodzaj = value;
					this.SendPropertyChanged("rodzaj");
					this.OnrodzajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haslo", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string haslo
		{
			get
			{
				return this._haslo;
			}
			set
			{
				if ((this._haslo != value))
				{
					this.OnhasloChanging(value);
					this.SendPropertyChanging();
					this._haslo = value;
					this.SendPropertyChanged("haslo");
					this.OnhasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Konto_Menu", Storage="_Menu", ThisKey="Id", OtherKey="Id_konto")]
		public EntitySet<Menu> Menu
		{
			get
			{
				return this._Menu;
			}
			set
			{
				this._Menu.Assign(value);
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
		
		private void attach_Menu(Menu entity)
		{
			this.SendPropertyChanging();
			entity.Konto = this;
		}
		
		private void detach_Menu(Menu entity)
		{
			this.SendPropertyChanging();
			entity.Konto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produkt_spozywczy")]
	public partial class Produkt_spozywczy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nazwa;
		
		private string _jednostka;
		
		private double _kalorie;
		
		private double _weglowodany;
		
		private double _bialka;
		
		private double _blonnik;
		
		private double _sol;
		
		private double _tluszcze;
		
		private EntitySet<Skladnik> _Skladniks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnazwaChanging(string value);
    partial void OnnazwaChanged();
    partial void OnjednostkaChanging(string value);
    partial void OnjednostkaChanged();
    partial void OnkalorieChanging(double value);
    partial void OnkalorieChanged();
    partial void OnweglowodanyChanging(double value);
    partial void OnweglowodanyChanged();
    partial void OnbialkaChanging(double value);
    partial void OnbialkaChanged();
    partial void OnblonnikChanging(double value);
    partial void OnblonnikChanged();
    partial void OnsolChanging(double value);
    partial void OnsolChanged();
    partial void OntluszczeChanging(double value);
    partial void OntluszczeChanged();
    #endregion
		
		public Produkt_spozywczy()
		{
			this._Skladniks = new EntitySet<Skladnik>(new Action<Skladnik>(this.attach_Skladniks), new Action<Skladnik>(this.detach_Skladniks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nazwa
		{
			get
			{
				return this._nazwa;
			}
			set
			{
				if ((this._nazwa != value))
				{
					this.OnnazwaChanging(value);
					this.SendPropertyChanging();
					this._nazwa = value;
					this.SendPropertyChanged("nazwa");
					this.OnnazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jednostka", DbType="NVarChar(4) NOT NULL", CanBeNull=false)]
		public string jednostka
		{
			get
			{
				return this._jednostka;
			}
			set
			{
				if ((this._jednostka != value))
				{
					this.OnjednostkaChanging(value);
					this.SendPropertyChanging();
					this._jednostka = value;
					this.SendPropertyChanged("jednostka");
					this.OnjednostkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kalorie", DbType="Float NOT NULL")]
		public double kalorie
		{
			get
			{
				return this._kalorie;
			}
			set
			{
				if ((this._kalorie != value))
				{
					this.OnkalorieChanging(value);
					this.SendPropertyChanging();
					this._kalorie = value;
					this.SendPropertyChanged("kalorie");
					this.OnkalorieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weglowodany", DbType="Float NOT NULL")]
		public double weglowodany
		{
			get
			{
				return this._weglowodany;
			}
			set
			{
				if ((this._weglowodany != value))
				{
					this.OnweglowodanyChanging(value);
					this.SendPropertyChanging();
					this._weglowodany = value;
					this.SendPropertyChanged("weglowodany");
					this.OnweglowodanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bialka", DbType="Float NOT NULL")]
		public double bialka
		{
			get
			{
				return this._bialka;
			}
			set
			{
				if ((this._bialka != value))
				{
					this.OnbialkaChanging(value);
					this.SendPropertyChanging();
					this._bialka = value;
					this.SendPropertyChanged("bialka");
					this.OnbialkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_blonnik", DbType="Float NOT NULL")]
		public double blonnik
		{
			get
			{
				return this._blonnik;
			}
			set
			{
				if ((this._blonnik != value))
				{
					this.OnblonnikChanging(value);
					this.SendPropertyChanging();
					this._blonnik = value;
					this.SendPropertyChanged("blonnik");
					this.OnblonnikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sol", DbType="Float NOT NULL")]
		public double sol
		{
			get
			{
				return this._sol;
			}
			set
			{
				if ((this._sol != value))
				{
					this.OnsolChanging(value);
					this.SendPropertyChanging();
					this._sol = value;
					this.SendPropertyChanged("sol");
					this.OnsolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tluszcze", DbType="Float NOT NULL")]
		public double tluszcze
		{
			get
			{
				return this._tluszcze;
			}
			set
			{
				if ((this._tluszcze != value))
				{
					this.OntluszczeChanging(value);
					this.SendPropertyChanging();
					this._tluszcze = value;
					this.SendPropertyChanged("tluszcze");
					this.OntluszczeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_spozywczy_Skladnik", Storage="_Skladniks", ThisKey="Id", OtherKey="Id_produktu")]
		public EntitySet<Skladnik> Skladniks
		{
			get
			{
				return this._Skladniks;
			}
			set
			{
				this._Skladniks.Assign(value);
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
		
		private void attach_Skladniks(Skladnik entity)
		{
			this.SendPropertyChanging();
			entity.Produkt_spozywczy = this;
		}
		
		private void detach_Skladniks(Skladnik entity)
		{
			this.SendPropertyChanging();
			entity.Produkt_spozywczy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_dania;
		
		private int _Id_konto;
		
		private System.DateTime _data;
		
		private string _komentarz;
		
		private EntityRef<Danie> _Danie;
		
		private EntityRef<Konto> _Konto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_daniaChanging(int value);
    partial void OnId_daniaChanged();
    partial void OnId_kontoChanging(int value);
    partial void OnId_kontoChanged();
    partial void OndataChanging(System.DateTime value);
    partial void OndataChanged();
    partial void OnkomentarzChanging(string value);
    partial void OnkomentarzChanged();
    #endregion
		
		public Menu()
		{
			this._Danie = default(EntityRef<Danie>);
			this._Konto = default(EntityRef<Konto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_dania", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_dania
		{
			get
			{
				return this._Id_dania;
			}
			set
			{
				if ((this._Id_dania != value))
				{
					if (this._Danie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_daniaChanging(value);
					this.SendPropertyChanging();
					this._Id_dania = value;
					this.SendPropertyChanged("Id_dania");
					this.OnId_daniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_konto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_konto
		{
			get
			{
				return this._Id_konto;
			}
			set
			{
				if ((this._Id_konto != value))
				{
					if (this._Konto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_kontoChanging(value);
					this.SendPropertyChanging();
					this._Id_konto = value;
					this.SendPropertyChanged("Id_konto");
					this.OnId_kontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="Date NOT NULL")]
		public System.DateTime data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_komentarz", DbType="NVarChar(MAX)")]
		public string komentarz
		{
			get
			{
				return this._komentarz;
			}
			set
			{
				if ((this._komentarz != value))
				{
					this.OnkomentarzChanging(value);
					this.SendPropertyChanging();
					this._komentarz = value;
					this.SendPropertyChanged("komentarz");
					this.OnkomentarzChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Danie_Menu", Storage="_Danie", ThisKey="Id_dania", OtherKey="Id", IsForeignKey=true)]
		public Danie Danie
		{
			get
			{
				return this._Danie.Entity;
			}
			set
			{
				Danie previousValue = this._Danie.Entity;
				if (((previousValue != value) 
							|| (this._Danie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Danie.Entity = null;
						previousValue.Menu.Remove(this);
					}
					this._Danie.Entity = value;
					if ((value != null))
					{
						value.Menu.Add(this);
						this._Id_dania = value.Id;
					}
					else
					{
						this._Id_dania = default(int);
					}
					this.SendPropertyChanged("Danie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Konto_Menu", Storage="_Konto", ThisKey="Id_konto", OtherKey="Id", IsForeignKey=true)]
		public Konto Konto
		{
			get
			{
				return this._Konto.Entity;
			}
			set
			{
				Konto previousValue = this._Konto.Entity;
				if (((previousValue != value) 
							|| (this._Konto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Konto.Entity = null;
						previousValue.Menu.Remove(this);
					}
					this._Konto.Entity = value;
					if ((value != null))
					{
						value.Menu.Add(this);
						this._Id_konto = value.Id;
					}
					else
					{
						this._Id_konto = default(int);
					}
					this.SendPropertyChanged("Konto");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Skladnik")]
	public partial class Skladnik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_dania;
		
		private int _Id_produktu;
		
		private int _ilosc;
		
		private EntityRef<Danie> _Danie;
		
		private EntityRef<Produkt_spozywczy> _Produkt_spozywczy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_daniaChanging(int value);
    partial void OnId_daniaChanged();
    partial void OnId_produktuChanging(int value);
    partial void OnId_produktuChanged();
    partial void OniloscChanging(int value);
    partial void OniloscChanged();
    #endregion
		
		public Skladnik()
		{
			this._Danie = default(EntityRef<Danie>);
			this._Produkt_spozywczy = default(EntityRef<Produkt_spozywczy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_dania", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_dania
		{
			get
			{
				return this._Id_dania;
			}
			set
			{
				if ((this._Id_dania != value))
				{
					if (this._Danie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_daniaChanging(value);
					this.SendPropertyChanging();
					this._Id_dania = value;
					this.SendPropertyChanged("Id_dania");
					this.OnId_daniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_produktu", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_produktu
		{
			get
			{
				return this._Id_produktu;
			}
			set
			{
				if ((this._Id_produktu != value))
				{
					if (this._Produkt_spozywczy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_produktuChanging(value);
					this.SendPropertyChanging();
					this._Id_produktu = value;
					this.SendPropertyChanged("Id_produktu");
					this.OnId_produktuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilosc", DbType="Int NOT NULL")]
		public int ilosc
		{
			get
			{
				return this._ilosc;
			}
			set
			{
				if ((this._ilosc != value))
				{
					this.OniloscChanging(value);
					this.SendPropertyChanging();
					this._ilosc = value;
					this.SendPropertyChanged("ilosc");
					this.OniloscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Danie_Skladnik", Storage="_Danie", ThisKey="Id_dania", OtherKey="Id", IsForeignKey=true)]
		public Danie Danie
		{
			get
			{
				return this._Danie.Entity;
			}
			set
			{
				Danie previousValue = this._Danie.Entity;
				if (((previousValue != value) 
							|| (this._Danie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Danie.Entity = null;
						previousValue.Skladniks.Remove(this);
					}
					this._Danie.Entity = value;
					if ((value != null))
					{
						value.Skladniks.Add(this);
						this._Id_dania = value.Id;
					}
					else
					{
						this._Id_dania = default(int);
					}
					this.SendPropertyChanged("Danie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_spozywczy_Skladnik", Storage="_Produkt_spozywczy", ThisKey="Id_produktu", OtherKey="Id", IsForeignKey=true)]
		public Produkt_spozywczy Produkt_spozywczy
		{
			get
			{
				return this._Produkt_spozywczy.Entity;
			}
			set
			{
				Produkt_spozywczy previousValue = this._Produkt_spozywczy.Entity;
				if (((previousValue != value) 
							|| (this._Produkt_spozywczy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produkt_spozywczy.Entity = null;
						previousValue.Skladniks.Remove(this);
					}
					this._Produkt_spozywczy.Entity = value;
					if ((value != null))
					{
						value.Skladniks.Add(this);
						this._Id_produktu = value.Id;
					}
					else
					{
						this._Id_produktu = default(int);
					}
					this.SendPropertyChanged("Produkt_spozywczy");
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
