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
public partial class TMSRoyaltyOneTimeCharges
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_RoyaltyOneTimeCharges]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _rdRoyaltyId;
	private System.String _rdRoyaltiMonth;
	private System.String _rdRoyaltyYear;
	private System.String _rdAdmissionCharges;
	private System.String _rdAnnualCharges;
	private System.String _rdRegistrationCharges;
	private System.String _rdStudentKitCharges;
	private System.String _rdUniformCharges;
	private System.String _rdAnnualDayCharges;
	private System.String _rdSportDayCharges;
	private System.String _rdPortfolioCharges;
	private System.String _rdMixExpensesCharges;
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
	
	public System.String RDRoyaltiMonth
	{
		get
		{
			return _rdRoyaltiMonth;
		}
		set
		{
			_rdRoyaltiMonth = value;
		}
	}
	
	public System.String RDRoyaltyYear
	{
		get
		{
			return _rdRoyaltyYear;
		}
		set
		{
			_rdRoyaltyYear = value;
		}
	}
	
	public System.String RDAdmissionCharges
	{
		get
		{
			return _rdAdmissionCharges;
		}
		set
		{
			_rdAdmissionCharges = value;
		}
	}
	
	public System.String RDAnnualCharges
	{
		get
		{
			return _rdAnnualCharges;
		}
		set
		{
			_rdAnnualCharges = value;
		}
	}
	
	public System.String RDRegistrationCharges
	{
		get
		{
			return _rdRegistrationCharges;
		}
		set
		{
			_rdRegistrationCharges = value;
		}
	}
	
	public System.String RDStudentKitCharges
	{
		get
		{
			return _rdStudentKitCharges;
		}
		set
		{
			_rdStudentKitCharges = value;
		}
	}
	
	public System.String RDUniformCharges
	{
		get
		{
			return _rdUniformCharges;
		}
		set
		{
			_rdUniformCharges = value;
		}
	}
	
	public System.String RDAnnualDayCharges
	{
		get
		{
			return _rdAnnualDayCharges;
		}
		set
		{
			_rdAnnualDayCharges = value;
		}
	}
	
	public System.String RDSportDayCharges
	{
		get
		{
			return _rdSportDayCharges;
		}
		set
		{
			_rdSportDayCharges = value;
		}
	}
	
	public System.String RDPortfolioCharges
	{
		get
		{
			return _rdPortfolioCharges;
		}
		set
		{
			_rdPortfolioCharges = value;
		}
	}
	
	public System.String RDMixExpensesCharges
	{
		get
		{
			return _rdMixExpensesCharges;
		}
		set
		{
			_rdMixExpensesCharges = value;
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
		ds.Tables[TABLE_NAME].Columns.Add("RD_RoyaltiMonth", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_RoyaltyYear", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AdmissionCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AnnualCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_RegistrationCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_StudentKitCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_UniformCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AnnualDayCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_SportDayCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_PortfolioCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_MixExpensesCharges", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (RDRoyaltyId == null)
		dr["RD_RoyaltyId"] = DBNull.Value;
		else
		dr["RD_RoyaltyId"] = RDRoyaltyId;
		
		if (RDRoyaltiMonth == null)
		dr["RD_RoyaltiMonth"] = DBNull.Value;
		else
		dr["RD_RoyaltiMonth"] = RDRoyaltiMonth;
		
		if (RDRoyaltyYear == null)
		dr["RD_RoyaltyYear"] = DBNull.Value;
		else
		dr["RD_RoyaltyYear"] = RDRoyaltyYear;
		
		if (RDAdmissionCharges == null)
		dr["RD_AdmissionCharges"] = DBNull.Value;
		else
		dr["RD_AdmissionCharges"] = RDAdmissionCharges;
		
		if (RDAnnualCharges == null)
		dr["RD_AnnualCharges"] = DBNull.Value;
		else
		dr["RD_AnnualCharges"] = RDAnnualCharges;
		
		if (RDRegistrationCharges == null)
		dr["RD_RegistrationCharges"] = DBNull.Value;
		else
		dr["RD_RegistrationCharges"] = RDRegistrationCharges;
		
		if (RDStudentKitCharges == null)
		dr["RD_StudentKitCharges"] = DBNull.Value;
		else
		dr["RD_StudentKitCharges"] = RDStudentKitCharges;
		
		if (RDUniformCharges == null)
		dr["RD_UniformCharges"] = DBNull.Value;
		else
		dr["RD_UniformCharges"] = RDUniformCharges;
		
		if (RDAnnualDayCharges == null)
		dr["RD_AnnualDayCharges"] = DBNull.Value;
		else
		dr["RD_AnnualDayCharges"] = RDAnnualDayCharges;
		
		if (RDSportDayCharges == null)
		dr["RD_SportDayCharges"] = DBNull.Value;
		else
		dr["RD_SportDayCharges"] = RDSportDayCharges;
		
		if (RDPortfolioCharges == null)
		dr["RD_PortfolioCharges"] = DBNull.Value;
		else
		dr["RD_PortfolioCharges"] = RDPortfolioCharges;
		
		if (RDMixExpensesCharges == null)
		dr["RD_MixExpensesCharges"] = DBNull.Value;
		else
		dr["RD_MixExpensesCharges"] = RDMixExpensesCharges;
		
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
		RDRoyaltiMonth = dr["RD_RoyaltiMonth"] != DBNull.Value ? Convert.ToString(dr["RD_RoyaltiMonth"]) : RDRoyaltiMonth = null;
		RDRoyaltyYear = dr["RD_RoyaltyYear"] != DBNull.Value ? Convert.ToString(dr["RD_RoyaltyYear"]) : RDRoyaltyYear = null;
		RDAdmissionCharges = dr["RD_AdmissionCharges"] != DBNull.Value ? Convert.ToString(dr["RD_AdmissionCharges"]) : RDAdmissionCharges = null;
		RDAnnualCharges = dr["RD_AnnualCharges"] != DBNull.Value ? Convert.ToString(dr["RD_AnnualCharges"]) : RDAnnualCharges = null;
		RDRegistrationCharges = dr["RD_RegistrationCharges"] != DBNull.Value ? Convert.ToString(dr["RD_RegistrationCharges"]) : RDRegistrationCharges = null;
		RDStudentKitCharges = dr["RD_StudentKitCharges"] != DBNull.Value ? Convert.ToString(dr["RD_StudentKitCharges"]) : RDStudentKitCharges = null;
		RDUniformCharges = dr["RD_UniformCharges"] != DBNull.Value ? Convert.ToString(dr["RD_UniformCharges"]) : RDUniformCharges = null;
		RDAnnualDayCharges = dr["RD_AnnualDayCharges"] != DBNull.Value ? Convert.ToString(dr["RD_AnnualDayCharges"]) : RDAnnualDayCharges = null;
		RDSportDayCharges = dr["RD_SportDayCharges"] != DBNull.Value ? Convert.ToString(dr["RD_SportDayCharges"]) : RDSportDayCharges = null;
		RDPortfolioCharges = dr["RD_PortfolioCharges"] != DBNull.Value ? Convert.ToString(dr["RD_PortfolioCharges"]) : RDPortfolioCharges = null;
		RDMixExpensesCharges = dr["RD_MixExpensesCharges"] != DBNull.Value ? Convert.ToString(dr["RD_MixExpensesCharges"]) : RDMixExpensesCharges = null;
		RDAddedById = dr["RD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["RD_AddedById"]) : RDAddedById = null;
		RDAddedByType = dr["RD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["RD_AddedByType"]) : RDAddedByType = null;
		RDDate = dr["RD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["RD_Date"]) : RDDate = null;
		RDStatus = dr["RD_Status"] != DBNull.Value ? Convert.ToInt32(dr["RD_Status"]) : RDStatus = null;
	}
	
	public static TMSRoyaltyOneTimeCharges[] MapFrom(DataSet ds)
	{
		List<TMSRoyaltyOneTimeCharges> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSRoyaltyOneTimeCharges>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_RoyaltyOneTimeCharges] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_RoyaltyOneTimeCharges] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSRoyaltyOneTimeCharges instance = new TMSRoyaltyOneTimeCharges();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRoyaltyOneTimeCharges Get(System.Int64 rdRoyaltyId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSRoyaltyOneTimeCharges instance;
		
		
		instance = new TMSRoyaltyOneTimeCharges();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSRoyaltyOneTimeCharges ID:" + rdRoyaltyId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltiMonth, rdRoyaltyYear, rdAdmissionCharges, rdAnnualCharges, rdRegistrationCharges, rdStudentKitCharges, rdUniformCharges, rdAnnualDayCharges, rdSportDayCharges, rdPortfolioCharges, rdMixExpensesCharges, rdAddedById, rdAddedByType, rdDate, rdStatus);
		
		if (transaction == null)
		this.RDRoyaltyId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.RDRoyaltyId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Insert(rdRoyaltiMonth, rdRoyaltyYear, rdAdmissionCharges, rdAnnualCharges, rdRegistrationCharges, rdStudentKitCharges, rdUniformCharges, rdAnnualDayCharges, rdSportDayCharges, rdPortfolioCharges, rdMixExpensesCharges, rdAddedById, rdAddedByType, rdDate, rdStatus, null);
	}
	/// <summary>
	/// Insert current TMSRoyaltyOneTimeCharges to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(RDRoyaltiMonth, RDRoyaltyYear, RDAdmissionCharges, RDAnnualCharges, RDRegistrationCharges, RDStudentKitCharges, RDUniformCharges, RDAnnualDayCharges, RDSportDayCharges, RDPortfolioCharges, RDMixExpensesCharges, RDAddedById, RDAddedByType, RDDate, RDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSRoyaltyOneTimeCharges to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? rdRoyaltyId, System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdRoyaltyId"].Value = rdRoyaltyId;
		dbCommand.Parameters["@rdRoyaltiMonth"].Value = rdRoyaltiMonth;
		dbCommand.Parameters["@rdRoyaltyYear"].Value = rdRoyaltyYear;
		dbCommand.Parameters["@rdAdmissionCharges"].Value = rdAdmissionCharges;
		dbCommand.Parameters["@rdAnnualCharges"].Value = rdAnnualCharges;
		dbCommand.Parameters["@rdRegistrationCharges"].Value = rdRegistrationCharges;
		dbCommand.Parameters["@rdStudentKitCharges"].Value = rdStudentKitCharges;
		dbCommand.Parameters["@rdUniformCharges"].Value = rdUniformCharges;
		dbCommand.Parameters["@rdAnnualDayCharges"].Value = rdAnnualDayCharges;
		dbCommand.Parameters["@rdSportDayCharges"].Value = rdSportDayCharges;
		dbCommand.Parameters["@rdPortfolioCharges"].Value = rdPortfolioCharges;
		dbCommand.Parameters["@rdMixExpensesCharges"].Value = rdMixExpensesCharges;
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
	public static void Update(System.Int64? rdRoyaltyId, System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Update(rdRoyaltyId, rdRoyaltiMonth, rdRoyaltyYear, rdAdmissionCharges, rdAnnualCharges, rdRegistrationCharges, rdStudentKitCharges, rdUniformCharges, rdAnnualDayCharges, rdSportDayCharges, rdPortfolioCharges, rdMixExpensesCharges, rdAddedById, rdAddedByType, rdDate, rdStatus, null);
	}
	
	public static void Update(TMSRoyaltyOneTimeCharges tMSRoyaltyOneTimeCharges)
	{
		tMSRoyaltyOneTimeCharges.Update();
	}
	
	public static void Update(TMSRoyaltyOneTimeCharges tMSRoyaltyOneTimeCharges, DbTransaction transaction)
	{
		tMSRoyaltyOneTimeCharges.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdRoyaltyId"].SourceColumn = "RD_RoyaltyId";
		dbCommand.Parameters["@rdRoyaltiMonth"].SourceColumn = "RD_RoyaltiMonth";
		dbCommand.Parameters["@rdRoyaltyYear"].SourceColumn = "RD_RoyaltyYear";
		dbCommand.Parameters["@rdAdmissionCharges"].SourceColumn = "RD_AdmissionCharges";
		dbCommand.Parameters["@rdAnnualCharges"].SourceColumn = "RD_AnnualCharges";
		dbCommand.Parameters["@rdRegistrationCharges"].SourceColumn = "RD_RegistrationCharges";
		dbCommand.Parameters["@rdStudentKitCharges"].SourceColumn = "RD_StudentKitCharges";
		dbCommand.Parameters["@rdUniformCharges"].SourceColumn = "RD_UniformCharges";
		dbCommand.Parameters["@rdAnnualDayCharges"].SourceColumn = "RD_AnnualDayCharges";
		dbCommand.Parameters["@rdSportDayCharges"].SourceColumn = "RD_SportDayCharges";
		dbCommand.Parameters["@rdPortfolioCharges"].SourceColumn = "RD_PortfolioCharges";
		dbCommand.Parameters["@rdMixExpensesCharges"].SourceColumn = "RD_MixExpensesCharges";
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
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_DELETE";
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
	/// Delete current TMSRoyaltyOneTimeCharges from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_DELETE";
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
	/// Delete current TMSRoyaltyOneTimeCharges from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRoyaltyOneTimeCharges[] Search(System.Int64? rdRoyaltyId, System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId, rdRoyaltiMonth, rdRoyaltyYear, rdAdmissionCharges, rdAnnualCharges, rdRegistrationCharges, rdStudentKitCharges, rdUniformCharges, rdAnnualDayCharges, rdSportDayCharges, rdPortfolioCharges, rdMixExpensesCharges, rdAddedById, rdAddedByType, rdDate, rdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSRoyaltyOneTimeCharges.MapFrom(ds);
	}
	
	
	public static TMSRoyaltyOneTimeCharges[] Search(TMSRoyaltyOneTimeCharges searchObject)
	{
		return Search ( searchObject.RDRoyaltyId, searchObject.RDRoyaltiMonth, searchObject.RDRoyaltyYear, searchObject.RDAdmissionCharges, searchObject.RDAnnualCharges, searchObject.RDRegistrationCharges, searchObject.RDStudentKitCharges, searchObject.RDUniformCharges, searchObject.RDAnnualDayCharges, searchObject.RDSportDayCharges, searchObject.RDPortfolioCharges, searchObject.RDMixExpensesCharges, searchObject.RDAddedById, searchObject.RDAddedByType, searchObject.RDDate, searchObject.RDStatus);
	}
	
	/// <summary>
	/// Returns all TMSRoyaltyOneTimeCharges objects.
	/// </summary>
	/// <returns>List of all TMSRoyaltyOneTimeCharges objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSRoyaltyOneTimeCharges[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

