/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/12/2012 3:32:58 PM                                    */
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
public partial class TMSLeaveAdvancedDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LeaveAdvancedDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ladDetailsId;
	private System.Int64? _ladLeaveDetailId;
	private System.Int64? _ladFacultyLoginId;
	private System.String _ladFacultyType;
	private System.String _ladLeaveType;
	private System.Int32? _ladJan;
	private System.Int32? _ladFeb;
	private System.Int32? _ladMar;
	private System.Int32? _ladApr;
	private System.Int32? _ladMay;
	private System.Int32? _ladJune;
	private System.Int32? _ladJuly;
	private System.Int32? _ladAug;
	private System.Int32? _ladSep;
	private System.Int32? _ladOct;
	private System.Int32? _ladNov;
	private System.Int32? _ladDec;
	private System.DateTime? _ladDate;
	private System.Int32? _ladStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LADDetailsId
	{
		get
		{
			return _ladDetailsId;
		}
		set
		{
			_ladDetailsId = value;
		}
	}
	
	public System.Int64? LADLeaveDetailId
	{
		get
		{
			return _ladLeaveDetailId;
		}
		set
		{
			_ladLeaveDetailId = value;
		}
	}
	
	public System.Int64? LADFacultyLoginId
	{
		get
		{
			return _ladFacultyLoginId;
		}
		set
		{
			_ladFacultyLoginId = value;
		}
	}
	
	public System.String LADFacultyType
	{
		get
		{
			return _ladFacultyType;
		}
		set
		{
			_ladFacultyType = value;
		}
	}
	
	public System.String LADLeaveType
	{
		get
		{
			return _ladLeaveType;
		}
		set
		{
			_ladLeaveType = value;
		}
	}
	
	public System.Int32? LADJan
	{
		get
		{
			return _ladJan;
		}
		set
		{
			_ladJan = value;
		}
	}
	
	public System.Int32? LADFeb
	{
		get
		{
			return _ladFeb;
		}
		set
		{
			_ladFeb = value;
		}
	}
	
	public System.Int32? LADMar
	{
		get
		{
			return _ladMar;
		}
		set
		{
			_ladMar = value;
		}
	}
	
	public System.Int32? LADApr
	{
		get
		{
			return _ladApr;
		}
		set
		{
			_ladApr = value;
		}
	}
	
	public System.Int32? LADMay
	{
		get
		{
			return _ladMay;
		}
		set
		{
			_ladMay = value;
		}
	}
	
	public System.Int32? LADJune
	{
		get
		{
			return _ladJune;
		}
		set
		{
			_ladJune = value;
		}
	}
	
	public System.Int32? LADJuly
	{
		get
		{
			return _ladJuly;
		}
		set
		{
			_ladJuly = value;
		}
	}
	
	public System.Int32? LADAug
	{
		get
		{
			return _ladAug;
		}
		set
		{
			_ladAug = value;
		}
	}
	
	public System.Int32? LADSep
	{
		get
		{
			return _ladSep;
		}
		set
		{
			_ladSep = value;
		}
	}
	
	public System.Int32? LADOct
	{
		get
		{
			return _ladOct;
		}
		set
		{
			_ladOct = value;
		}
	}
	
	public System.Int32? LADNov
	{
		get
		{
			return _ladNov;
		}
		set
		{
			_ladNov = value;
		}
	}
	
	public System.Int32? LADDec
	{
		get
		{
			return _ladDec;
		}
		set
		{
			_ladDec = value;
		}
	}
	
	public System.DateTime? LADDate
	{
		get
		{
			return _ladDate;
		}
		set
		{
			_ladDate = value;
		}
	}
	
	public System.Int32? LADStatus
	{
		get
		{
			return _ladStatus;
		}
		set
		{
			_ladStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LAD_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_LeaveDetailId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FacultyType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_LeaveType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Jan", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Feb", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Mar", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Apr", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_May", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_June", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_July", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Aug", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Sep", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Oct", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Nov", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Dec", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LADDetailsId == null)
		dr["LAD_DetailsId"] = DBNull.Value;
		else
		dr["LAD_DetailsId"] = LADDetailsId;
		
		if (LADLeaveDetailId == null)
		dr["LAD_LeaveDetailId"] = DBNull.Value;
		else
		dr["LAD_LeaveDetailId"] = LADLeaveDetailId;
		
		if (LADFacultyLoginId == null)
		dr["LAD_FacultyLoginId"] = DBNull.Value;
		else
		dr["LAD_FacultyLoginId"] = LADFacultyLoginId;
		
		if (LADFacultyType == null)
		dr["LAD_FacultyType"] = DBNull.Value;
		else
		dr["LAD_FacultyType"] = LADFacultyType;
		
		if (LADLeaveType == null)
		dr["LAD_LeaveType"] = DBNull.Value;
		else
		dr["LAD_LeaveType"] = LADLeaveType;
		
		if (LADJan == null)
		dr["LAD_Jan"] = DBNull.Value;
		else
		dr["LAD_Jan"] = LADJan;
		
		if (LADFeb == null)
		dr["LAD_Feb"] = DBNull.Value;
		else
		dr["LAD_Feb"] = LADFeb;
		
		if (LADMar == null)
		dr["LAD_Mar"] = DBNull.Value;
		else
		dr["LAD_Mar"] = LADMar;
		
		if (LADApr == null)
		dr["LAD_Apr"] = DBNull.Value;
		else
		dr["LAD_Apr"] = LADApr;
		
		if (LADMay == null)
		dr["LAD_May"] = DBNull.Value;
		else
		dr["LAD_May"] = LADMay;
		
		if (LADJune == null)
		dr["LAD_June"] = DBNull.Value;
		else
		dr["LAD_June"] = LADJune;
		
		if (LADJuly == null)
		dr["LAD_July"] = DBNull.Value;
		else
		dr["LAD_July"] = LADJuly;
		
		if (LADAug == null)
		dr["LAD_Aug"] = DBNull.Value;
		else
		dr["LAD_Aug"] = LADAug;
		
		if (LADSep == null)
		dr["LAD_Sep"] = DBNull.Value;
		else
		dr["LAD_Sep"] = LADSep;
		
		if (LADOct == null)
		dr["LAD_Oct"] = DBNull.Value;
		else
		dr["LAD_Oct"] = LADOct;
		
		if (LADNov == null)
		dr["LAD_Nov"] = DBNull.Value;
		else
		dr["LAD_Nov"] = LADNov;
		
		if (LADDec == null)
		dr["LAD_Dec"] = DBNull.Value;
		else
		dr["LAD_Dec"] = LADDec;
		
		if (LADDate == null)
		dr["LAD_Date"] = DBNull.Value;
		else
		dr["LAD_Date"] = LADDate;
		
		if (LADStatus == null)
		dr["LAD_Status"] = DBNull.Value;
		else
		dr["LAD_Status"] = LADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LADDetailsId = dr["LAD_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_DetailsId"]) : LADDetailsId = null;
		LADLeaveDetailId = dr["LAD_LeaveDetailId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_LeaveDetailId"]) : LADLeaveDetailId = null;
		LADFacultyLoginId = dr["LAD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_FacultyLoginId"]) : LADFacultyLoginId = null;
		LADFacultyType = dr["LAD_FacultyType"] != DBNull.Value ? Convert.ToString(dr["LAD_FacultyType"]) : LADFacultyType = null;
		LADLeaveType = dr["LAD_LeaveType"] != DBNull.Value ? Convert.ToString(dr["LAD_LeaveType"]) : LADLeaveType = null;
		LADJan = dr["LAD_Jan"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Jan"]) : LADJan = null;
		LADFeb = dr["LAD_Feb"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Feb"]) : LADFeb = null;
		LADMar = dr["LAD_Mar"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Mar"]) : LADMar = null;
		LADApr = dr["LAD_Apr"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Apr"]) : LADApr = null;
		LADMay = dr["LAD_May"] != DBNull.Value ? Convert.ToInt32(dr["LAD_May"]) : LADMay = null;
		LADJune = dr["LAD_June"] != DBNull.Value ? Convert.ToInt32(dr["LAD_June"]) : LADJune = null;
		LADJuly = dr["LAD_July"] != DBNull.Value ? Convert.ToInt32(dr["LAD_July"]) : LADJuly = null;
		LADAug = dr["LAD_Aug"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Aug"]) : LADAug = null;
		LADSep = dr["LAD_Sep"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Sep"]) : LADSep = null;
		LADOct = dr["LAD_Oct"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Oct"]) : LADOct = null;
		LADNov = dr["LAD_Nov"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Nov"]) : LADNov = null;
		LADDec = dr["LAD_Dec"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Dec"]) : LADDec = null;
		LADDate = dr["LAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LAD_Date"]) : LADDate = null;
		LADStatus = dr["LAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Status"]) : LADStatus = null;
	}
	
	public static TMSLeaveAdvancedDetails[] MapFrom(DataSet ds)
	{
		List<TMSLeaveAdvancedDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLeaveAdvancedDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LeaveAdvancedDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LeaveAdvancedDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLeaveAdvancedDetails instance = new TMSLeaveAdvancedDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeaveAdvancedDetails Get(System.Int64 ladDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLeaveAdvancedDetails instance;
		
		
		instance = new TMSLeaveAdvancedDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLeaveAdvancedDetails ID:" + ladDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladLeaveDetailId, ladFacultyLoginId, ladFacultyType, ladLeaveType, ladJan, ladFeb, ladMar, ladApr, ladMay, ladJune, ladJuly, ladAug, ladSep, ladOct, ladNov, ladDec, ladDate, ladStatus);
		
		if (transaction == null)
		this.LADDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LADDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		Insert(ladLeaveDetailId, ladFacultyLoginId, ladFacultyType, ladLeaveType, ladJan, ladFeb, ladMar, ladApr, ladMay, ladJune, ladJuly, ladAug, ladSep, ladOct, ladNov, ladDec, ladDate, ladStatus, null);
	}
	/// <summary>
	/// Insert current TMSLeaveAdvancedDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LADLeaveDetailId, LADFacultyLoginId, LADFacultyType, LADLeaveType, LADJan, LADFeb, LADMar, LADApr, LADMay, LADJune, LADJuly, LADAug, LADSep, LADOct, LADNov, LADDec, LADDate, LADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLeaveAdvancedDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ladDetailsId, System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ladDetailsId"].Value = ladDetailsId;
		dbCommand.Parameters["@ladLeaveDetailId"].Value = ladLeaveDetailId;
		dbCommand.Parameters["@ladFacultyLoginId"].Value = ladFacultyLoginId;
		dbCommand.Parameters["@ladFacultyType"].Value = ladFacultyType;
		dbCommand.Parameters["@ladLeaveType"].Value = ladLeaveType;
		dbCommand.Parameters["@ladJan"].Value = ladJan;
		dbCommand.Parameters["@ladFeb"].Value = ladFeb;
		dbCommand.Parameters["@ladMar"].Value = ladMar;
		dbCommand.Parameters["@ladApr"].Value = ladApr;
		dbCommand.Parameters["@ladMay"].Value = ladMay;
		dbCommand.Parameters["@ladJune"].Value = ladJune;
		dbCommand.Parameters["@ladJuly"].Value = ladJuly;
		dbCommand.Parameters["@ladAug"].Value = ladAug;
		dbCommand.Parameters["@ladSep"].Value = ladSep;
		dbCommand.Parameters["@ladOct"].Value = ladOct;
		dbCommand.Parameters["@ladNov"].Value = ladNov;
		dbCommand.Parameters["@ladDec"].Value = ladDec;
		dbCommand.Parameters["@ladDate"].Value = ladDate;
		dbCommand.Parameters["@ladStatus"].Value = ladStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ladDetailsId, System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		Update(ladDetailsId, ladLeaveDetailId, ladFacultyLoginId, ladFacultyType, ladLeaveType, ladJan, ladFeb, ladMar, ladApr, ladMay, ladJune, ladJuly, ladAug, ladSep, ladOct, ladNov, ladDec, ladDate, ladStatus, null);
	}
	
	public static void Update(TMSLeaveAdvancedDetails tMSLeaveAdvancedDetails)
	{
		tMSLeaveAdvancedDetails.Update();
	}
	
	public static void Update(TMSLeaveAdvancedDetails tMSLeaveAdvancedDetails, DbTransaction transaction)
	{
		tMSLeaveAdvancedDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ladDetailsId"].SourceColumn = "LAD_DetailsId";
		dbCommand.Parameters["@ladLeaveDetailId"].SourceColumn = "LAD_LeaveDetailId";
		dbCommand.Parameters["@ladFacultyLoginId"].SourceColumn = "LAD_FacultyLoginId";
		dbCommand.Parameters["@ladFacultyType"].SourceColumn = "LAD_FacultyType";
		dbCommand.Parameters["@ladLeaveType"].SourceColumn = "LAD_LeaveType";
		dbCommand.Parameters["@ladJan"].SourceColumn = "LAD_Jan";
		dbCommand.Parameters["@ladFeb"].SourceColumn = "LAD_Feb";
		dbCommand.Parameters["@ladMar"].SourceColumn = "LAD_Mar";
		dbCommand.Parameters["@ladApr"].SourceColumn = "LAD_Apr";
		dbCommand.Parameters["@ladMay"].SourceColumn = "LAD_May";
		dbCommand.Parameters["@ladJune"].SourceColumn = "LAD_June";
		dbCommand.Parameters["@ladJuly"].SourceColumn = "LAD_July";
		dbCommand.Parameters["@ladAug"].SourceColumn = "LAD_Aug";
		dbCommand.Parameters["@ladSep"].SourceColumn = "LAD_Sep";
		dbCommand.Parameters["@ladOct"].SourceColumn = "LAD_Oct";
		dbCommand.Parameters["@ladNov"].SourceColumn = "LAD_Nov";
		dbCommand.Parameters["@ladDec"].SourceColumn = "LAD_Dec";
		dbCommand.Parameters["@ladDate"].SourceColumn = "LAD_Date";
		dbCommand.Parameters["@ladStatus"].SourceColumn = "LAD_Status";
		
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
	public static void Delete(System.Int64? ladDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladDetailsId);
		
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
	public static void Delete(System.Int64? ladDetailsId)
	{
		Delete(
		ladDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSLeaveAdvancedDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LADDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LADDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSLeaveAdvancedDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeaveAdvancedDetails[] Search(System.Int64? ladDetailsId, System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladDetailsId, ladLeaveDetailId, ladFacultyLoginId, ladFacultyType, ladLeaveType, ladJan, ladFeb, ladMar, ladApr, ladMay, ladJune, ladJuly, ladAug, ladSep, ladOct, ladNov, ladDec, ladDate, ladStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLeaveAdvancedDetails.MapFrom(ds);
	}
	
	
	public static TMSLeaveAdvancedDetails[] Search(TMSLeaveAdvancedDetails searchObject)
	{
		return Search ( searchObject.LADDetailsId, searchObject.LADLeaveDetailId, searchObject.LADFacultyLoginId, searchObject.LADFacultyType, searchObject.LADLeaveType, searchObject.LADJan, searchObject.LADFeb, searchObject.LADMar, searchObject.LADApr, searchObject.LADMay, searchObject.LADJune, searchObject.LADJuly, searchObject.LADAug, searchObject.LADSep, searchObject.LADOct, searchObject.LADNov, searchObject.LADDec, searchObject.LADDate, searchObject.LADStatus);
	}
	
	/// <summary>
	/// Returns all TMSLeaveAdvancedDetails objects.
	/// </summary>
	/// <returns>List of all TMSLeaveAdvancedDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLeaveAdvancedDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

