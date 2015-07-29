/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 6:01:52 PM                                    */
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
public partial class TMSUnitTestDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_UnitTestDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _utdUnitTestId;
	private System.Int64? _utdSchoolCatId;
	private System.Int64? _utdSchoolSubCatId;
	private System.String _utdTitle;
	private System.String _utdDescription;
	private System.String _utdStartPeriod;
	private System.String _utdEndPeriod;
	private System.DateTime? _utdStartDate;
	private System.DateTime? _utdEndDate;
	private System.String _utdAddedBy;
	private System.DateTime? _utdDate;
	private System.Int32? _utdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? UTDUnitTestId
	{
		get
		{
			return _utdUnitTestId;
		}
		set
		{
			_utdUnitTestId = value;
		}
	}
	
	public System.Int64? UTDSchoolCatId
	{
		get
		{
			return _utdSchoolCatId;
		}
		set
		{
			_utdSchoolCatId = value;
		}
	}
	
	public System.Int64? UTDSchoolSubCatId
	{
		get
		{
			return _utdSchoolSubCatId;
		}
		set
		{
			_utdSchoolSubCatId = value;
		}
	}
	
	public System.String UTDTitle
	{
		get
		{
			return _utdTitle;
		}
		set
		{
			_utdTitle = value;
		}
	}
	
	public System.String UTDDescription
	{
		get
		{
			return _utdDescription;
		}
		set
		{
			_utdDescription = value;
		}
	}
	
	public System.String UTDStartPeriod
	{
		get
		{
			return _utdStartPeriod;
		}
		set
		{
			_utdStartPeriod = value;
		}
	}
	
	public System.String UTDEndPeriod
	{
		get
		{
			return _utdEndPeriod;
		}
		set
		{
			_utdEndPeriod = value;
		}
	}
	
	public System.DateTime? UTDStartDate
	{
		get
		{
			return _utdStartDate;
		}
		set
		{
			_utdStartDate = value;
		}
	}
	
	public System.DateTime? UTDEndDate
	{
		get
		{
			return _utdEndDate;
		}
		set
		{
			_utdEndDate = value;
		}
	}
	
	public System.String UTDAddedBy
	{
		get
		{
			return _utdAddedBy;
		}
		set
		{
			_utdAddedBy = value;
		}
	}
	
	public System.DateTime? UTDDate
	{
		get
		{
			return _utdDate;
		}
		set
		{
			_utdDate = value;
		}
	}
	
	public System.Int32? UTDStatus
	{
		get
		{
			return _utdStatus;
		}
		set
		{
			_utdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("UTD_UnitTestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_SchoolSubCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_StartPeriod", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_EndPeriod", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_StartDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_EndDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_AddedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UTD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (UTDUnitTestId == null)
		dr["UTD_UnitTestId"] = DBNull.Value;
		else
		dr["UTD_UnitTestId"] = UTDUnitTestId;
		
		if (UTDSchoolCatId == null)
		dr["UTD_SchoolCatId"] = DBNull.Value;
		else
		dr["UTD_SchoolCatId"] = UTDSchoolCatId;
		
		if (UTDSchoolSubCatId == null)
		dr["UTD_SchoolSubCatId"] = DBNull.Value;
		else
		dr["UTD_SchoolSubCatId"] = UTDSchoolSubCatId;
		
		if (UTDTitle == null)
		dr["UTD_Title"] = DBNull.Value;
		else
		dr["UTD_Title"] = UTDTitle;
		
		if (UTDDescription == null)
		dr["UTD_Description"] = DBNull.Value;
		else
		dr["UTD_Description"] = UTDDescription;
		
		if (UTDStartPeriod == null)
		dr["UTD_StartPeriod"] = DBNull.Value;
		else
		dr["UTD_StartPeriod"] = UTDStartPeriod;
		
		if (UTDEndPeriod == null)
		dr["UTD_EndPeriod"] = DBNull.Value;
		else
		dr["UTD_EndPeriod"] = UTDEndPeriod;
		
		if (UTDStartDate == null)
		dr["UTD_StartDate"] = DBNull.Value;
		else
		dr["UTD_StartDate"] = UTDStartDate;
		
		if (UTDEndDate == null)
		dr["UTD_EndDate"] = DBNull.Value;
		else
		dr["UTD_EndDate"] = UTDEndDate;
		
		if (UTDAddedBy == null)
		dr["UTD_AddedBy"] = DBNull.Value;
		else
		dr["UTD_AddedBy"] = UTDAddedBy;
		
		if (UTDDate == null)
		dr["UTD_Date"] = DBNull.Value;
		else
		dr["UTD_Date"] = UTDDate;
		
		if (UTDStatus == null)
		dr["UTD_Status"] = DBNull.Value;
		else
		dr["UTD_Status"] = UTDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		UTDUnitTestId = dr["UTD_UnitTestId"] != DBNull.Value ? Convert.ToInt64(dr["UTD_UnitTestId"]) : UTDUnitTestId = null;
		UTDSchoolCatId = dr["UTD_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["UTD_SchoolCatId"]) : UTDSchoolCatId = null;
		UTDSchoolSubCatId = dr["UTD_SchoolSubCatId"] != DBNull.Value ? Convert.ToInt64(dr["UTD_SchoolSubCatId"]) : UTDSchoolSubCatId = null;
		UTDTitle = dr["UTD_Title"] != DBNull.Value ? Convert.ToString(dr["UTD_Title"]) : UTDTitle = null;
		UTDDescription = dr["UTD_Description"] != DBNull.Value ? Convert.ToString(dr["UTD_Description"]) : UTDDescription = null;
		UTDStartPeriod = dr["UTD_StartPeriod"] != DBNull.Value ? Convert.ToString(dr["UTD_StartPeriod"]) : UTDStartPeriod = null;
		UTDEndPeriod = dr["UTD_EndPeriod"] != DBNull.Value ? Convert.ToString(dr["UTD_EndPeriod"]) : UTDEndPeriod = null;
		UTDStartDate = dr["UTD_StartDate"] != DBNull.Value ? Convert.ToDateTime(dr["UTD_StartDate"]) : UTDStartDate = null;
		UTDEndDate = dr["UTD_EndDate"] != DBNull.Value ? Convert.ToDateTime(dr["UTD_EndDate"]) : UTDEndDate = null;
		UTDAddedBy = dr["UTD_AddedBy"] != DBNull.Value ? Convert.ToString(dr["UTD_AddedBy"]) : UTDAddedBy = null;
		UTDDate = dr["UTD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["UTD_Date"]) : UTDDate = null;
		UTDStatus = dr["UTD_Status"] != DBNull.Value ? Convert.ToInt32(dr["UTD_Status"]) : UTDStatus = null;
	}
	
	public static TMSUnitTestDetails[] MapFrom(DataSet ds)
	{
		List<TMSUnitTestDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSUnitTestDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_UnitTestDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_UnitTestDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSUnitTestDetails instance = new TMSUnitTestDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUnitTestDetails Get(System.Int64 utdUnitTestId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSUnitTestDetails instance;
		
		
		instance = new TMSUnitTestDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utdUnitTestId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSUnitTestDetails ID:" + utdUnitTestId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utdSchoolCatId, utdSchoolSubCatId, utdTitle, utdDescription, utdStartPeriod, utdEndPeriod, utdStartDate, utdEndDate, utdAddedBy, utdDate, utdStatus);
		
		if (transaction == null)
		this.UTDUnitTestId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.UTDUnitTestId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus)
	{
		Insert(utdSchoolCatId, utdSchoolSubCatId, utdTitle, utdDescription, utdStartPeriod, utdEndPeriod, utdStartDate, utdEndDate, utdAddedBy, utdDate, utdStatus, null);
	}
	/// <summary>
	/// Insert current TMSUnitTestDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(UTDSchoolCatId, UTDSchoolSubCatId, UTDTitle, UTDDescription, UTDStartPeriod, UTDEndPeriod, UTDStartDate, UTDEndDate, UTDAddedBy, UTDDate, UTDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSUnitTestDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? utdUnitTestId, System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@utdUnitTestId"].Value = utdUnitTestId;
		dbCommand.Parameters["@utdSchoolCatId"].Value = utdSchoolCatId;
		dbCommand.Parameters["@utdSchoolSubCatId"].Value = utdSchoolSubCatId;
		dbCommand.Parameters["@utdTitle"].Value = utdTitle;
		dbCommand.Parameters["@utdDescription"].Value = utdDescription;
		dbCommand.Parameters["@utdStartPeriod"].Value = utdStartPeriod;
		dbCommand.Parameters["@utdEndPeriod"].Value = utdEndPeriod;
		dbCommand.Parameters["@utdStartDate"].Value = utdStartDate;
		dbCommand.Parameters["@utdEndDate"].Value = utdEndDate;
		dbCommand.Parameters["@utdAddedBy"].Value = utdAddedBy;
		dbCommand.Parameters["@utdDate"].Value = utdDate;
		dbCommand.Parameters["@utdStatus"].Value = utdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? utdUnitTestId, System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus)
	{
		Update(utdUnitTestId, utdSchoolCatId, utdSchoolSubCatId, utdTitle, utdDescription, utdStartPeriod, utdEndPeriod, utdStartDate, utdEndDate, utdAddedBy, utdDate, utdStatus, null);
	}
	
	public static void Update(TMSUnitTestDetails tMSUnitTestDetails)
	{
		tMSUnitTestDetails.Update();
	}
	
	public static void Update(TMSUnitTestDetails tMSUnitTestDetails, DbTransaction transaction)
	{
		tMSUnitTestDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSUnitTestDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@utdUnitTestId"].SourceColumn = "UTD_UnitTestId";
		dbCommand.Parameters["@utdSchoolCatId"].SourceColumn = "UTD_SchoolCatId";
		dbCommand.Parameters["@utdSchoolSubCatId"].SourceColumn = "UTD_SchoolSubCatId";
		dbCommand.Parameters["@utdTitle"].SourceColumn = "UTD_Title";
		dbCommand.Parameters["@utdDescription"].SourceColumn = "UTD_Description";
		dbCommand.Parameters["@utdStartPeriod"].SourceColumn = "UTD_StartPeriod";
		dbCommand.Parameters["@utdEndPeriod"].SourceColumn = "UTD_EndPeriod";
		dbCommand.Parameters["@utdStartDate"].SourceColumn = "UTD_StartDate";
		dbCommand.Parameters["@utdEndDate"].SourceColumn = "UTD_EndDate";
		dbCommand.Parameters["@utdAddedBy"].SourceColumn = "UTD_AddedBy";
		dbCommand.Parameters["@utdDate"].SourceColumn = "UTD_Date";
		dbCommand.Parameters["@utdStatus"].SourceColumn = "UTD_Status";
		
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
	public static void Delete(System.Int64? utdUnitTestId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utdUnitTestId);
		
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
	public static void Delete(System.Int64? utdUnitTestId)
	{
		Delete(
		utdUnitTestId);
	}
	
	/// <summary>
	/// Delete current TMSUnitTestDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, UTDUnitTestId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.UTDUnitTestId = null;
	}
	
	/// <summary>
	/// Delete current TMSUnitTestDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUnitTestDetails[] Search(System.Int64? utdUnitTestId, System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUnitTestDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utdUnitTestId, utdSchoolCatId, utdSchoolSubCatId, utdTitle, utdDescription, utdStartPeriod, utdEndPeriod, utdStartDate, utdEndDate, utdAddedBy, utdDate, utdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSUnitTestDetails.MapFrom(ds);
	}
	
	
	public static TMSUnitTestDetails[] Search(TMSUnitTestDetails searchObject)
	{
		return Search ( searchObject.UTDUnitTestId, searchObject.UTDSchoolCatId, searchObject.UTDSchoolSubCatId, searchObject.UTDTitle, searchObject.UTDDescription, searchObject.UTDStartPeriod, searchObject.UTDEndPeriod, searchObject.UTDStartDate, searchObject.UTDEndDate, searchObject.UTDAddedBy, searchObject.UTDDate, searchObject.UTDStatus);
	}
	
	/// <summary>
	/// Returns all TMSUnitTestDetails objects.
	/// </summary>
	/// <returns>List of all TMSUnitTestDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSUnitTestDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

