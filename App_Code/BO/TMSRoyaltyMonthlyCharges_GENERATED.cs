/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/26/2012 10:43:22 AM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSRoyaltyMonthlyCharges
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_RoyaltyMonthlyCharges]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _rdRoyaltyId;
	private System.String _rdMonth;
	private System.String _rdYear;
	private System.String _rdTutionFees;
	private System.String _rdDayCareCharges;
	private System.String _rdMealCharges;
	private System.String _rdTransportationCharges;
	private System.String _rdActivityCharges;
	private System.String _rdMisExpenses;
	private System.String _rdnttFees;
	private System.String _rdctetCoaching;
	private System.String _rdForeignLanFees;
	private System.Int64? _rdAddedById;
	private System.String _rdAddedByType;
	private System.DateTime? _rdDate;
	private System.Int32? _rdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? RDRoyaltyId
	{
		get
		{
			return _rdRoyaltyId;
		}
		set
		{
			_rdRoyaltyId = value;
		}
	}
	
	public System.String RDMonth
	{
		get
		{
			return _rdMonth;
		}
		set
		{
			_rdMonth = value;
		}
	}
	
	public System.String RDYear
	{
		get
		{
			return _rdYear;
		}
		set
		{
			_rdYear = value;
		}
	}
	
	public System.String RDTutionFees
	{
		get
		{
			return _rdTutionFees;
		}
		set
		{
			_rdTutionFees = value;
		}
	}
	
	public System.String RDDayCareCharges
	{
		get
		{
			return _rdDayCareCharges;
		}
		set
		{
			_rdDayCareCharges = value;
		}
	}
	
	public System.String RDMealCharges
	{
		get
		{
			return _rdMealCharges;
		}
		set
		{
			_rdMealCharges = value;
		}
	}
	
	public System.String RDTransportationCharges
	{
		get
		{
			return _rdTransportationCharges;
		}
		set
		{
			_rdTransportationCharges = value;
		}
	}
	
	public System.String RDActivityCharges
	{
		get
		{
			return _rdActivityCharges;
		}
		set
		{
			_rdActivityCharges = value;
		}
	}
	
	public System.String RDMisExpenses
	{
		get
		{
			return _rdMisExpenses;
		}
		set
		{
			_rdMisExpenses = value;
		}
	}
	
	public System.String RDNTTFees
	{
		get
		{
			return _rdnttFees;
		}
		set
		{
			_rdnttFees = value;
		}
	}
	
	public System.String RDCTETCoaching
	{
		get
		{
			return _rdctetCoaching;
		}
		set
		{
			_rdctetCoaching = value;
		}
	}
	
	public System.String RDForeignLanFees
	{
		get
		{
			return _rdForeignLanFees;
		}
		set
		{
			_rdForeignLanFees = value;
		}
	}
	
	public System.Int64? RDAddedById
	{
		get
		{
			return _rdAddedById;
		}
		set
		{
			_rdAddedById = value;
		}
	}
	
	public System.String RDAddedByType
	{
		get
		{
			return _rdAddedByType;
		}
		set
		{
			_rdAddedByType = value;
		}
	}
	
	public System.DateTime? RDDate
	{
		get
		{
			return _rdDate;
		}
		set
		{
			_rdDate = value;
		}
	}
	
	public System.Int32? RDStatus
	{
		get
		{
			return _rdStatus;
		}
		set
		{
			_rdStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("RD_RoyaltyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_TutionFees", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_DayCareCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_MealCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_TransportationCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ActivityCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_MisExpenses", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_NTTFees", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_CTETCoaching", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ForeignLanFees", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (RDRoyaltyId == null)
		dr["RD_RoyaltyId"] = DBNull.Value;
		else
		dr["RD_RoyaltyId"] = RDRoyaltyId;
		
		if (RDMonth == null)
		dr["RD_Month"] = DBNull.Value;
		else
		dr["RD_Month"] = RDMonth;
		
		if (RDYear == null)
		dr["RD_Year"] = DBNull.Value;
		else
		dr["RD_Year"] = RDYear;
		
		if (RDTutionFees == null)
		dr["RD_TutionFees"] = DBNull.Value;
		else
		dr["RD_TutionFees"] = RDTutionFees;
		
		if (RDDayCareCharges == null)
		dr["RD_DayCareCharges"] = DBNull.Value;
		else
		dr["RD_DayCareCharges"] = RDDayCareCharges;
		
		if (RDMealCharges == null)
		dr["RD_MealCharges"] = DBNull.Value;
		else
		dr["RD_MealCharges"] = RDMealCharges;
		
		if (RDTransportationCharges == null)
		dr["RD_TransportationCharges"] = DBNull.Value;
		else
		dr["RD_TransportationCharges"] = RDTransportationCharges;
		
		if (RDActivityCharges == null)
		dr["RD_ActivityCharges"] = DBNull.Value;
		else
		dr["RD_ActivityCharges"] = RDActivityCharges;
		
		if (RDMisExpenses == null)
		dr["RD_MisExpenses"] = DBNull.Value;
		else
		dr["RD_MisExpenses"] = RDMisExpenses;
		
		if (RDNTTFees == null)
		dr["RD_NTTFees"] = DBNull.Value;
		else
		dr["RD_NTTFees"] = RDNTTFees;
		
		if (RDCTETCoaching == null)
		dr["RD_CTETCoaching"] = DBNull.Value;
		else
		dr["RD_CTETCoaching"] = RDCTETCoaching;
		
		if (RDForeignLanFees == null)
		dr["RD_ForeignLanFees"] = DBNull.Value;
		else
		dr["RD_ForeignLanFees"] = RDForeignLanFees;
		
		if (RDAddedById == null)
		dr["RD_AddedById"] = DBNull.Value;
		else
		dr["RD_AddedById"] = RDAddedById;
		
		if (RDAddedByType == null)
		dr["RD_AddedByType"] = DBNull.Value;
		else
		dr["RD_AddedByType"] = RDAddedByType;
		
		if (RDDate == null)
		dr["RD_Date"] = DBNull.Value;
		else
		dr["RD_Date"] = RDDate;
		
		if (RDStatus == null)
		dr["RD_Status"] = DBNull.Value;
		else
		dr["RD_Status"] = RDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		RDRoyaltyId = dr["RD_RoyaltyId"] != DBNull.Value ? Convert.ToInt64(dr["RD_RoyaltyId"]) : RDRoyaltyId = null;
		RDMonth = dr["RD_Month"] != DBNull.Value ? Convert.ToString(dr["RD_Month"]) : RDMonth = null;
		RDYear = dr["RD_Year"] != DBNull.Value ? Convert.ToString(dr["RD_Year"]) : RDYear = null;
		RDTutionFees = dr["RD_TutionFees"] != DBNull.Value ? Convert.ToString(dr["RD_TutionFees"]) : RDTutionFees = null;
		RDDayCareCharges = dr["RD_DayCareCharges"] != DBNull.Value ? Convert.ToString(dr["RD_DayCareCharges"]) : RDDayCareCharges = null;
		RDMealCharges = dr["RD_MealCharges"] != DBNull.Value ? Convert.ToString(dr["RD_MealCharges"]) : RDMealCharges = null;
		RDTransportationCharges = dr["RD_TransportationCharges"] != DBNull.Value ? Convert.ToString(dr["RD_TransportationCharges"]) : RDTransportationCharges = null;
		RDActivityCharges = dr["RD_ActivityCharges"] != DBNull.Value ? Convert.ToString(dr["RD_ActivityCharges"]) : RDActivityCharges = null;
		RDMisExpenses = dr["RD_MisExpenses"] != DBNull.Value ? Convert.ToString(dr["RD_MisExpenses"]) : RDMisExpenses = null;
		RDNTTFees = dr["RD_NTTFees"] != DBNull.Value ? Convert.ToString(dr["RD_NTTFees"]) : RDNTTFees = null;
		RDCTETCoaching = dr["RD_CTETCoaching"] != DBNull.Value ? Convert.ToString(dr["RD_CTETCoaching"]) : RDCTETCoaching = null;
		RDForeignLanFees = dr["RD_ForeignLanFees"] != DBNull.Value ? Convert.ToString(dr["RD_ForeignLanFees"]) : RDForeignLanFees = null;
		RDAddedById = dr["RD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["RD_AddedById"]) : RDAddedById = null;
		RDAddedByType = dr["RD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["RD_AddedByType"]) : RDAddedByType = null;
		RDDate = dr["RD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["RD_Date"]) : RDDate = null;
		RDStatus = dr["RD_Status"] != DBNull.Value ? Convert.ToInt32(dr["RD_Status"]) : RDStatus = null;
	}
	
	public static TMSRoyaltyMonthlyCharges[] MapFrom(DataSet ds)
	{
		List<TMSRoyaltyMonthlyCharges> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSRoyaltyMonthlyCharges>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_RoyaltyMonthlyCharges] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_RoyaltyMonthlyCharges] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSRoyaltyMonthlyCharges instance = new TMSRoyaltyMonthlyCharges();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRoyaltyMonthlyCharges Get(System.Int64 rdRoyaltyId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSRoyaltyMonthlyCharges instance;
		
		
		instance = new TMSRoyaltyMonthlyCharges();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSRoyaltyMonthlyCharges ID:" + rdRoyaltyId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdMonth, rdYear, rdTutionFees, rdDayCareCharges, rdMealCharges, rdTransportationCharges, rdActivityCharges, rdMisExpenses, rdnttFees, rdctetCoaching, rdForeignLanFees, rdAddedById, rdAddedByType, rdDate, rdStatus);
		
		if (transaction == null)
		this.RDRoyaltyId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.RDRoyaltyId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Insert(rdMonth, rdYear, rdTutionFees, rdDayCareCharges, rdMealCharges, rdTransportationCharges, rdActivityCharges, rdMisExpenses, rdnttFees, rdctetCoaching, rdForeignLanFees, rdAddedById, rdAddedByType, rdDate, rdStatus, null);
	}
	/// <summary>
	/// Insert current TMSRoyaltyMonthlyCharges to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(RDMonth, RDYear, RDTutionFees, RDDayCareCharges, RDMealCharges, RDTransportationCharges, RDActivityCharges, RDMisExpenses, RDNTTFees, RDCTETCoaching, RDForeignLanFees, RDAddedById, RDAddedByType, RDDate, RDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSRoyaltyMonthlyCharges to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? rdRoyaltyId, System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdRoyaltyId"].Value = rdRoyaltyId;
		dbCommand.Parameters["@rdMonth"].Value = rdMonth;
		dbCommand.Parameters["@rdYear"].Value = rdYear;
		dbCommand.Parameters["@rdTutionFees"].Value = rdTutionFees;
		dbCommand.Parameters["@rdDayCareCharges"].Value = rdDayCareCharges;
		dbCommand.Parameters["@rdMealCharges"].Value = rdMealCharges;
		dbCommand.Parameters["@rdTransportationCharges"].Value = rdTransportationCharges;
		dbCommand.Parameters["@rdActivityCharges"].Value = rdActivityCharges;
		dbCommand.Parameters["@rdMisExpenses"].Value = rdMisExpenses;
		dbCommand.Parameters["@rdnttFees"].Value = rdnttFees;
		dbCommand.Parameters["@rdctetCoaching"].Value = rdctetCoaching;
		dbCommand.Parameters["@rdForeignLanFees"].Value = rdForeignLanFees;
		dbCommand.Parameters["@rdAddedById"].Value = rdAddedById;
		dbCommand.Parameters["@rdAddedByType"].Value = rdAddedByType;
		dbCommand.Parameters["@rdDate"].Value = rdDate;
		dbCommand.Parameters["@rdStatus"].Value = rdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? rdRoyaltyId, System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Update(rdRoyaltyId, rdMonth, rdYear, rdTutionFees, rdDayCareCharges, rdMealCharges, rdTransportationCharges, rdActivityCharges, rdMisExpenses, rdnttFees, rdctetCoaching, rdForeignLanFees, rdAddedById, rdAddedByType, rdDate, rdStatus, null);
	}
	
	public static void Update(TMSRoyaltyMonthlyCharges tMSRoyaltyMonthlyCharges)
	{
		tMSRoyaltyMonthlyCharges.Update();
	}
	
	public static void Update(TMSRoyaltyMonthlyCharges tMSRoyaltyMonthlyCharges, DbTransaction transaction)
	{
		tMSRoyaltyMonthlyCharges.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdRoyaltyId"].SourceColumn = "RD_RoyaltyId";
		dbCommand.Parameters["@rdMonth"].SourceColumn = "RD_Month";
		dbCommand.Parameters["@rdYear"].SourceColumn = "RD_Year";
		dbCommand.Parameters["@rdTutionFees"].SourceColumn = "RD_TutionFees";
		dbCommand.Parameters["@rdDayCareCharges"].SourceColumn = "RD_DayCareCharges";
		dbCommand.Parameters["@rdMealCharges"].SourceColumn = "RD_MealCharges";
		dbCommand.Parameters["@rdTransportationCharges"].SourceColumn = "RD_TransportationCharges";
		dbCommand.Parameters["@rdActivityCharges"].SourceColumn = "RD_ActivityCharges";
		dbCommand.Parameters["@rdMisExpenses"].SourceColumn = "RD_MisExpenses";
		dbCommand.Parameters["@rdnttFees"].SourceColumn = "RD_NTTFees";
		dbCommand.Parameters["@rdctetCoaching"].SourceColumn = "RD_CTETCoaching";
		dbCommand.Parameters["@rdForeignLanFees"].SourceColumn = "RD_ForeignLanFees";
		dbCommand.Parameters["@rdAddedById"].SourceColumn = "RD_AddedById";
		dbCommand.Parameters["@rdAddedByType"].SourceColumn = "RD_AddedByType";
		dbCommand.Parameters["@rdDate"].SourceColumn = "RD_Date";
		dbCommand.Parameters["@rdStatus"].SourceColumn = "RD_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? rdRoyaltyId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? rdRoyaltyId)
	{
		Delete(
		rdRoyaltyId);
	}
	
	/// <summary>
	/// Delete current TMSRoyaltyMonthlyCharges from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, RDRoyaltyId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.RDRoyaltyId = null;
	}
	
	/// <summary>
	/// Delete current TMSRoyaltyMonthlyCharges from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRoyaltyMonthlyCharges[] Search(System.Int64? rdRoyaltyId, System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId, rdMonth, rdYear, rdTutionFees, rdDayCareCharges, rdMealCharges, rdTransportationCharges, rdActivityCharges, rdMisExpenses, rdnttFees, rdctetCoaching, rdForeignLanFees, rdAddedById, rdAddedByType, rdDate, rdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSRoyaltyMonthlyCharges.MapFrom(ds);
	}
	
	
	public static TMSRoyaltyMonthlyCharges[] Search(TMSRoyaltyMonthlyCharges searchObject)
	{
		return Search ( searchObject.RDRoyaltyId, searchObject.RDMonth, searchObject.RDYear, searchObject.RDTutionFees, searchObject.RDDayCareCharges, searchObject.RDMealCharges, searchObject.RDTransportationCharges, searchObject.RDActivityCharges, searchObject.RDMisExpenses, searchObject.RDNTTFees, searchObject.RDCTETCoaching, searchObject.RDForeignLanFees, searchObject.RDAddedById, searchObject.RDAddedByType, searchObject.RDDate, searchObject.RDStatus);
	}
	
	/// <summary>
	/// Returns all TMSRoyaltyMonthlyCharges objects.
	/// </summary>
	/// <returns>List of all TMSRoyaltyMonthlyCharges objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSRoyaltyMonthlyCharges[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

