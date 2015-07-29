/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/25/2012 11:10:56 AM                                    */
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
public partial class TMSHomeWorkDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_HomeWorkDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _hwdHomeWorkId;
	private System.Int64? _hwdFacultyId;
	private System.Int64? _hwdFacultyLoginId;
	private System.Int64? _hwdSchoolId;
	private System.Int64? _hwdSchoolSubId;
	private System.Int64? _hwdSubjectId;
	private System.String _hwdTitle;
	private System.String _hwdDescription;
	private System.DateTime? _hwdSubmitDate;
	private System.DateTime? _hwdDate;
	private System.Int32? _hwdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? HWDHomeWorkId
	{
		get
		{
			return _hwdHomeWorkId;
		}
		set
		{
			_hwdHomeWorkId = value;
		}
	}
	
	public System.Int64? HWDFacultyId
	{
		get
		{
			return _hwdFacultyId;
		}
		set
		{
			_hwdFacultyId = value;
		}
	}
	
	public System.Int64? HWDFacultyLoginId
	{
		get
		{
			return _hwdFacultyLoginId;
		}
		set
		{
			_hwdFacultyLoginId = value;
		}
	}
	
	public System.Int64? HWDSchoolId
	{
		get
		{
			return _hwdSchoolId;
		}
		set
		{
			_hwdSchoolId = value;
		}
	}
	
	public System.Int64? HWDSchoolSubId
	{
		get
		{
			return _hwdSchoolSubId;
		}
		set
		{
			_hwdSchoolSubId = value;
		}
	}
	
	public System.Int64? HWDSubjectId
	{
		get
		{
			return _hwdSubjectId;
		}
		set
		{
			_hwdSubjectId = value;
		}
	}
	
	public System.String HWDTitle
	{
		get
		{
			return _hwdTitle;
		}
		set
		{
			_hwdTitle = value;
		}
	}
	
	public System.String HWDDescription
	{
		get
		{
			return _hwdDescription;
		}
		set
		{
			_hwdDescription = value;
		}
	}
	
	public System.DateTime? HWDSubmitDate
	{
		get
		{
			return _hwdSubmitDate;
		}
		set
		{
			_hwdSubmitDate = value;
		}
	}
	
	public System.DateTime? HWDDate
	{
		get
		{
			return _hwdDate;
		}
		set
		{
			_hwdDate = value;
		}
	}
	
	public System.Int32? HWDStatus
	{
		get
		{
			return _hwdStatus;
		}
		set
		{
			_hwdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("HWD_HomeWorkId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_SubmitDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("HWD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (HWDHomeWorkId == null)
		dr["HWD_HomeWorkId"] = DBNull.Value;
		else
		dr["HWD_HomeWorkId"] = HWDHomeWorkId;
		
		if (HWDFacultyId == null)
		dr["HWD_FacultyId"] = DBNull.Value;
		else
		dr["HWD_FacultyId"] = HWDFacultyId;
		
		if (HWDFacultyLoginId == null)
		dr["HWD_FacultyLoginId"] = DBNull.Value;
		else
		dr["HWD_FacultyLoginId"] = HWDFacultyLoginId;
		
		if (HWDSchoolId == null)
		dr["HWD_SchoolId"] = DBNull.Value;
		else
		dr["HWD_SchoolId"] = HWDSchoolId;
		
		if (HWDSchoolSubId == null)
		dr["HWD_SchoolSubId"] = DBNull.Value;
		else
		dr["HWD_SchoolSubId"] = HWDSchoolSubId;
		
		if (HWDSubjectId == null)
		dr["HWD_SubjectId"] = DBNull.Value;
		else
		dr["HWD_SubjectId"] = HWDSubjectId;
		
		if (HWDTitle == null)
		dr["HWD_Title"] = DBNull.Value;
		else
		dr["HWD_Title"] = HWDTitle;
		
		if (HWDDescription == null)
		dr["HWD_Description"] = DBNull.Value;
		else
		dr["HWD_Description"] = HWDDescription;
		
		if (HWDSubmitDate == null)
		dr["HWD_SubmitDate"] = DBNull.Value;
		else
		dr["HWD_SubmitDate"] = HWDSubmitDate;
		
		if (HWDDate == null)
		dr["HWD_Date"] = DBNull.Value;
		else
		dr["HWD_Date"] = HWDDate;
		
		if (HWDStatus == null)
		dr["HWD_Status"] = DBNull.Value;
		else
		dr["HWD_Status"] = HWDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		HWDHomeWorkId = dr["HWD_HomeWorkId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_HomeWorkId"]) : HWDHomeWorkId = null;
		HWDFacultyId = dr["HWD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_FacultyId"]) : HWDFacultyId = null;
		HWDFacultyLoginId = dr["HWD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_FacultyLoginId"]) : HWDFacultyLoginId = null;
		HWDSchoolId = dr["HWD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_SchoolId"]) : HWDSchoolId = null;
		HWDSchoolSubId = dr["HWD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_SchoolSubId"]) : HWDSchoolSubId = null;
		HWDSubjectId = dr["HWD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["HWD_SubjectId"]) : HWDSubjectId = null;
		HWDTitle = dr["HWD_Title"] != DBNull.Value ? Convert.ToString(dr["HWD_Title"]) : HWDTitle = null;
		HWDDescription = dr["HWD_Description"] != DBNull.Value ? Convert.ToString(dr["HWD_Description"]) : HWDDescription = null;
		HWDSubmitDate = dr["HWD_SubmitDate"] != DBNull.Value ? Convert.ToDateTime(dr["HWD_SubmitDate"]) : HWDSubmitDate = null;
		HWDDate = dr["HWD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["HWD_Date"]) : HWDDate = null;
		HWDStatus = dr["HWD_Status"] != DBNull.Value ? Convert.ToInt32(dr["HWD_Status"]) : HWDStatus = null;
	}
	
	public static TMSHomeWorkDetails[] MapFrom(DataSet ds)
	{
		List<TMSHomeWorkDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSHomeWorkDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_HomeWorkDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_HomeWorkDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSHomeWorkDetails instance = new TMSHomeWorkDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSHomeWorkDetails Get(System.Int64 hwdHomeWorkId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSHomeWorkDetails instance;
		
		
		instance = new TMSHomeWorkDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hwdHomeWorkId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSHomeWorkDetails ID:" + hwdHomeWorkId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hwdFacultyId, hwdFacultyLoginId, hwdSchoolId, hwdSchoolSubId, hwdSubjectId, hwdTitle, hwdDescription, hwdSubmitDate, hwdDate, hwdStatus);
		
		if (transaction == null)
		this.HWDHomeWorkId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.HWDHomeWorkId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus)
	{
		Insert(hwdFacultyId, hwdFacultyLoginId, hwdSchoolId, hwdSchoolSubId, hwdSubjectId, hwdTitle, hwdDescription, hwdSubmitDate, hwdDate, hwdStatus, null);
	}
	/// <summary>
	/// Insert current TMSHomeWorkDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(HWDFacultyId, HWDFacultyLoginId, HWDSchoolId, HWDSchoolSubId, HWDSubjectId, HWDTitle, HWDDescription, HWDSubmitDate, HWDDate, HWDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSHomeWorkDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? hwdHomeWorkId, System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@hwdHomeWorkId"].Value = hwdHomeWorkId;
		dbCommand.Parameters["@hwdFacultyId"].Value = hwdFacultyId;
		dbCommand.Parameters["@hwdFacultyLoginId"].Value = hwdFacultyLoginId;
		dbCommand.Parameters["@hwdSchoolId"].Value = hwdSchoolId;
		dbCommand.Parameters["@hwdSchoolSubId"].Value = hwdSchoolSubId;
		dbCommand.Parameters["@hwdSubjectId"].Value = hwdSubjectId;
		dbCommand.Parameters["@hwdTitle"].Value = hwdTitle;
		dbCommand.Parameters["@hwdDescription"].Value = hwdDescription;
		dbCommand.Parameters["@hwdSubmitDate"].Value = hwdSubmitDate;
		dbCommand.Parameters["@hwdDate"].Value = hwdDate;
		dbCommand.Parameters["@hwdStatus"].Value = hwdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? hwdHomeWorkId, System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus)
	{
		Update(hwdHomeWorkId, hwdFacultyId, hwdFacultyLoginId, hwdSchoolId, hwdSchoolSubId, hwdSubjectId, hwdTitle, hwdDescription, hwdSubmitDate, hwdDate, hwdStatus, null);
	}
	
	public static void Update(TMSHomeWorkDetails tMSHomeWorkDetails)
	{
		tMSHomeWorkDetails.Update();
	}
	
	public static void Update(TMSHomeWorkDetails tMSHomeWorkDetails, DbTransaction transaction)
	{
		tMSHomeWorkDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@hwdHomeWorkId"].SourceColumn = "HWD_HomeWorkId";
		dbCommand.Parameters["@hwdFacultyId"].SourceColumn = "HWD_FacultyId";
		dbCommand.Parameters["@hwdFacultyLoginId"].SourceColumn = "HWD_FacultyLoginId";
		dbCommand.Parameters["@hwdSchoolId"].SourceColumn = "HWD_SchoolId";
		dbCommand.Parameters["@hwdSchoolSubId"].SourceColumn = "HWD_SchoolSubId";
		dbCommand.Parameters["@hwdSubjectId"].SourceColumn = "HWD_SubjectId";
		dbCommand.Parameters["@hwdTitle"].SourceColumn = "HWD_Title";
		dbCommand.Parameters["@hwdDescription"].SourceColumn = "HWD_Description";
		dbCommand.Parameters["@hwdSubmitDate"].SourceColumn = "HWD_SubmitDate";
		dbCommand.Parameters["@hwdDate"].SourceColumn = "HWD_Date";
		dbCommand.Parameters["@hwdStatus"].SourceColumn = "HWD_Status";
		
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
	public static void Delete(System.Int64? hwdHomeWorkId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hwdHomeWorkId);
		
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
	public static void Delete(System.Int64? hwdHomeWorkId)
	{
		Delete(
		hwdHomeWorkId);
	}
	
	/// <summary>
	/// Delete current TMSHomeWorkDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, HWDHomeWorkId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.HWDHomeWorkId = null;
	}
	
	/// <summary>
	/// Delete current TMSHomeWorkDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSHomeWorkDetails[] Search(System.Int64? hwdHomeWorkId, System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHomeWorkDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hwdHomeWorkId, hwdFacultyId, hwdFacultyLoginId, hwdSchoolId, hwdSchoolSubId, hwdSubjectId, hwdTitle, hwdDescription, hwdSubmitDate, hwdDate, hwdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSHomeWorkDetails.MapFrom(ds);
	}
	
	
	public static TMSHomeWorkDetails[] Search(TMSHomeWorkDetails searchObject)
	{
		return Search ( searchObject.HWDHomeWorkId, searchObject.HWDFacultyId, searchObject.HWDFacultyLoginId, searchObject.HWDSchoolId, searchObject.HWDSchoolSubId, searchObject.HWDSubjectId, searchObject.HWDTitle, searchObject.HWDDescription, searchObject.HWDSubmitDate, searchObject.HWDDate, searchObject.HWDStatus);
	}
	
	/// <summary>
	/// Returns all TMSHomeWorkDetails objects.
	/// </summary>
	/// <returns>List of all TMSHomeWorkDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSHomeWorkDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

