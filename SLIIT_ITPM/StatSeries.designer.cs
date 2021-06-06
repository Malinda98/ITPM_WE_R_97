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

namespace SLIIT_ITPM
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ITP_SLIIT")]
	public partial class StatSeriesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public StatSeriesDataContext() : 
				base(global::SLIIT_ITPM.Properties.Settings.Default.ITP_SLIITConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StatSeriesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatSeriesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatSeriesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatSeriesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vmcount> vmcount
		{
			get
			{
				return this.GetTable<vmcount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vmcount")]
	public partial class vmcount
	{
		
		private System.Nullable<int> _std_count;
		
		private System.Nullable<int> _lec_count;
		
		public vmcount()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_std_count", DbType="Int")]
		public System.Nullable<int> std_count
		{
			get
			{
				return this._std_count;
			}
			set
			{
				if ((this._std_count != value))
				{
					this._std_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lec_count", DbType="Int")]
		public System.Nullable<int> lec_count
		{
			get
			{
				return this._lec_count;
			}
			set
			{
				if ((this._lec_count != value))
				{
					this._lec_count = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
