/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/9/2012 12:55:23 PM                                    */
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
public partial class TMSCampusUpdateDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CampusUpdateDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cudCampusId;
	private System.Int64? _cudFacultyLoginId;
	private System.Int64? _cudSchoolId;
	private System.Int64? _cudSchoolSubId;
	private System.String _cudTitle;
	private System.String _cudDescription;
	private System.String _cudImageName1;
	private System.String _cudImageName2;
	private System.String _cudExtra;
	private System.DateTime? _cudCampusDate;
	private System.DateTime? _cudDate;
	private System.Int32? _cudStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CUDCampusId
	{
		get
		{
			return _cudCampusId;
		}
		set
		{
			_cudCampusId = value;
		}
	}
	
	public System.Int64? CUDFacultyLoginId
	{
		get
		{
			return _cudFacultyLoginId;
		}
		set
		{
			_cudFacultyLoginId = value;
		}
	}
	
	public System.Int64? CUDSchoolId
	{
		get
		{
			return _cudSchoolId;
		}
		set
		{
			_cudSchoolId = value;
		}
	}
	
	public System.Int64? CUDSchoolSubId
	{
		get
		{
			return _cudSchoolSubId;
		}
		set
		{
			_cudSchoolSubId = value;
		}
	}
	
	public System.String CUDTitle
	{
		get
		{
			return _cudTitle;
		}
		set
		{
			_cudTitle = value;
		}
	}
	
	public System.String CUDDescription
	{
		get
		{
			return _cudDescription;
		}
		set
		{
			_cudDescription = value;
		}
	}
	
	public System.String CUDImageName1
	{
		get
		{
			return _cudImageName1;
		}
		set
		{
			_cudImageName1 = value;
		}
	}
	
	public System.String CUDImageName2
	{
		get
		{
			return _cudImageName2;
		}
		set
		{
			_cudImageName2 = value;
		}
	}
	
	public System.String CUDExtra
	{
		get
		{
			return _cudExtra;
		}
		set
		{
			_cudExtra = value;
		}
	}
	
	public System.DateTime? CUDCampusDate
	{
		get
		{
			return _cudCampusDate;
		}
		set
		{
			_cudCampusDate = value;
		}
	}
	
	public System.DateTime? CUDDate
	{
		get
		{
			return _cudDate;
		}
		set
		{
			_cudDate = value;
		}
	}
	
	public System.Int32? CUDStatus
	{
		get
		{
			return _cudStatus;
		}
		set
		{
			_cudStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CUD_CampusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_ImageName1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_ImageName2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_CampusDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CUD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CUDCampusId == null)
		dr["CUD_CampusId"] = DBNull.Value;
		else
		dr["CUD_CampusId"] = CUDCampusId;
		
		if (CUDFacultyLoginId == null)
		dr["CUD_FacultyLoginId"] = DBNull.Value;
		else
		dr["CUD_FacultyLoginId"] = CUDFacultyLoginId;
		
		if (CUDSchoolId == null)
		dr["CUD_SchoolId"] = DBNull.Value;
		else
		dr["CUD_SchoolId"] = CUDSchoolId;
		
		if (CUDSchoolSubId == null)
		dr["CUD_SchoolSubId"] = DBNull.Value;
		else
		dr["CUD_SchoolSubId"] = CUDSchoolSubId;
		
		if (CUDTitle == null)
		dr["CUD_Title"] = DBNull.Value;
		else
		dr["CUD_Title"] = CUDTitle;
		
		if (CUDDescription == null)
		dr["CUD_Description"] = DBNull.Value;
		else
		dr["CUD_Description"] = CUDDescription;
		
		if (CUDImageName1 == null)
		dr["CUD_ImageName1"] = DBNull.Value;
		else
		dr["CUD_ImageName1"] = CUDImageName1;
		
		if (CUDImageName2 == null)
		dr["CUD_ImageName2"] = DBNull.Value;
		else
		dr["CUD_ImageName2"] = CUDImageName2;
		
		if (CUDExtra == null)
		dr["CUD_Extra"] = DBNull.Value;
		else
		dr["CUD_Extra"] = CUDExtra;
		
		if (CUDCampusDate == null)
		dr["CUD_CampusDate"] = DBNull.Value;
		else
		dr["CUD_CampusDate"] = CUDCampusDate;
		
		if (CUDDate == null)
		dr["CUD_Date"] = DBNull.Value;
		else
		dr["CUD_Date"] = CUDDate;
		
		if (CUDStatus == null)
		dr["CUD_Status"] = DBNull.Value;
		else
		dr["CUD_Status"] = CUDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CUDCampusId = dr["CUD_CampusId"] != DBNull.Value ? Convert.ToInt64(dr["CUD_CampusId"]) : CUDCampusId = null;
		CUDFacultyLoginId = dr["CUD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["CUD_FacultyLoginId"]) : CUDFacultyLoginId = null;
		CUDSchoolId = dr["CUD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["CUD_SchoolId"]) : CUDSchoolId = null;
		CUDSchoolSubId = dr["CUD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["CUD_SchoolSubId"]) : CUDSchoolSubId = null;
		CUDTitle = dr["CUD_Title"] != DBNull.Value ? Convert.ToString(dr["CUD_Title"]) : CUDTitle = null;
		CUDDescription = dr["CUD_Description"] != DBNull.Value ? Convert.ToString(dr["CUD_Description"]) : CUDDescription = null;
		CUDImageName1 = dr["CUD_ImageName1"] != DBNull.Value ? Convert.ToString(dr["CUD_ImageName1"]) : CUDImageName1 = null;
		CUDImageName2 = dr["CUD_ImageName2"] != DBNull.Value ? Convert.ToString(dr["CUD_ImageName2"]) : CUDImageName2 = null;
		CUDExtra = dr["CUD_Extra"] != DBNull.Value ? Convert.ToString(dr["CUD_Extra"]) : CUDExtra = null;
		CUDCampusDate = dr["CUD_CampusDate"] != DBNull.Value ? Convert.ToDateTime(dr["CUD_CampusDate"]) : CUDCampusDate = null;
		CUDDate = dr["CUD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CUD_Date"]) : CUDDate = null;
		CUDStatus = dr["CUD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CUD_Status"]) : CUDStatus = null;
	}
	
	public static TMSCampusUpdateDetails[] MapFrom(DataSet ds)
	{
		List<TMSCampusUpdateDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCampusUpdateDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CampusUpdateDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CampusUpdateDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCampusUpdateDetails instance = new TMSCampusUpdateDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCampusUpdateDetails Get(System.Int64 cudCampusId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCampusUpdateDetails instance;
		
		
		instance = new TMSCampusUpdateDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cudCampusId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCampusUpdateDetails ID:" + cudCampusId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cudFacultyLoginId, cudSchoolId, cudSchoolSubId, cudTitle, cudDescription, cudImageName1, cudImageName2, cudExtra, cudCampusDate, cudDate, cudStatus);
		
		if (transaction == null)
		this.CUDCampusId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CUDCampusId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus)
	{
		Insert(cudFacultyLoginId, cudSchoolId, cudSchoolSubId, cudTitle, cudDescription, cudImageName1, cudImageName2, cudExtra, cudCampusDate, cudDate, cudStatus, null);
	}
	/// <summary>
	/// Insert current TMSCampusUpdateDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CUDFacultyLoginId, CUDSchoolId, CUDSchoolSubId, CUDTitle, CUDDescription, CUDImageName1, CUDImageName2, CUDExtra, CUDCampusDate, CUDDate, CUDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCampusUpdateDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cudCampusId, System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cudCampusId"].Value = cudCampusId;
		dbCommand.Parameters["@cudFacultyLoginId"].Value = cudFacultyLoginId;
		dbCommand.Parameters["@cudSchoolId"].Value = cudSchoolId;
		dbCommand.Parameters["@cudSchoolSubId"].Value = cudSchoolSubId;
		dbCommand.Parameters["@cudTitle"].Value = cudTitle;
		dbCommand.Parameters["@cudDescription"].Value = cudDescription;
		dbCommand.Parameters["@cudImageName1"].Value = cudImageName1;
		dbCommand.Parameters["@cudImageName2"].Value = cudImageName2;
		dbCommand.Parameters["@cudExtra"].Value = cudExtra;
		dbCommand.Parameters["@cudCampusDate"].Value = cudCampusDate;
		dbCommand.Parameters["@cudDate"].Value = cudDate;
		dbCommand.Parameters["@cudStatus"].Value = cudStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cudCampusId, System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus)
	{
		Update(cudCampusId, cudFacultyLoginId, cudSchoolId, cudSchoolSubId, cudTitle, cudDescription, cudImageName1, cudImageName2, cudExtra, cudCampusDate, cudDate, cudStatus, null);
	}
	
	public static void Update(TMSCampusUpdateDetails tMSCampusUpdateDetails)
	{
		tMSCampusUpdateDetails.Update();
	}
	
	public static void Update(TMSCampusUpdateDetails tMSCampusUpdateDetails, DbTransaction transaction)
	{
		tMSCampusUpdateDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cudCampusId"].SourceColumn = "CUD_CampusId";
		dbCommand.Parameters["@cudFacultyLoginId"].SourceColumn = "CUD_FacultyLoginId";
		dbCommand.Parameters["@cudSchoolId"].SourceColumn = "CUD_SchoolId";
		dbCommand.Parameters["@cudSchoolSubId"].SourceColumn = "CUD_SchoolSubId";
		dbCommand.Parameters["@cudTitle"].SourceColumn = "CUD_Title";
		dbCommand.Parameters["@cudDescription"].SourceColumn = "CUD_Description";
		dbCommand.Parameters["@cudImageName1"].SourceColumn = "CUD_ImageName1";
		dbCommand.Parameters["@cudImageName2"].SourceColumn = "CUD_ImageName2";
		dbCommand.Parameters["@cudExtra"].SourceColumn = "CUD_Extra";
		dbCommand.Parameters["@cudCampusDate"].SourceColumn = "CUD_CampusDate";
		dbCommand.Parameters["@cudDate"].SourceColumn = "CUD_Date";
		dbCommand.Parameters["@cudStatus"].SourceColumn = "CUD_Status";
		
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
	public static void Delete(System.Int64? cudCampusId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cudCampusId);
		
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
	public static void Delete(System.Int64? cudCampusId)
	{
		Delete(
		cudCampusId);
	}
	
	/// <summary>
	/// Delete current TMSCampusUpdateDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CUDCampusId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CUDCampusId = null;
	}
	
	/// <summary>
	/// Delete current TMSCampusUpdateDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCampusUpdateDetails[] Search(System.Int64? cudCampusId, System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCampusUpdateDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cudCampusId, cudFacultyLoginId, cudSchoolId, cudSchoolSubId, cudTitle, cudDescription, cudImageName1, cudImageName2, cudExtra, cudCampusDate, cudDate, cudStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCampusUpdateDetails.MapFrom(ds);
	}
	
	
	public static TMSCampusUpdateDetails[] Search(TMSCampusUpdateDetails searchObject)
	{
		return Search ( searchObject.CUDCampusId, searchObject.CUDFacultyLoginId, searchObject.CUDSchoolId, searchObject.CUDSchoolSubId, searchObject.CUDTitle, searchObject.CUDDescription, searchObject.CUDImageName1, searchObject.CUDImageName2, searchObject.CUDExtra, searchObject.CUDCampusDate, searchObject.CUDDate, searchObject.CUDStatus);
	}
	
	/// <summary>
	/// Returns all TMSCampusUpdateDetails objects.
	/// </summary>
	/// <returns>List of all TMSCampusUpdateDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCampusUpdateDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

