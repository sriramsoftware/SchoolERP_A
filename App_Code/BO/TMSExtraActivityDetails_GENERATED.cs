/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/4/2012 1:01:29 PM                                    */
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
public partial class TMSExtraActivityDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExtraActivityDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _eadTimelineId;
	private System.Int64? _eadFacultyLoginId;
	private System.Int64? _eadStudentLoginId;
	private System.String _eadProgressType;
	private System.Int64? _eadExtraActivityId;
	private System.Int64? _eadSchoolId;
	private System.Int64? _eadSchoolSubId;
	private System.String _eadExamTerm;
	private System.String _eadExtraActivity1;
	private System.String _eadExtraActivity2;
	private System.String _eadRemarks;
	private System.String _eadAddeByType;
	private System.Int64? _eadAddedById;
	private System.DateTime? _eadDate;
	private System.Int32? _eadStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? EADTimelineId
	{
		get
		{
			return _eadTimelineId;
		}
		set
		{
			_eadTimelineId = value;
		}
	}
	
	public System.Int64? EADFacultyLoginId
	{
		get
		{
			return _eadFacultyLoginId;
		}
		set
		{
			_eadFacultyLoginId = value;
		}
	}
	
	public System.Int64? EADStudentLoginId
	{
		get
		{
			return _eadStudentLoginId;
		}
		set
		{
			_eadStudentLoginId = value;
		}
	}
	
	public System.String EADProgressType
	{
		get
		{
			return _eadProgressType;
		}
		set
		{
			_eadProgressType = value;
		}
	}
	
	public System.Int64? EADExtraActivityId
	{
		get
		{
			return _eadExtraActivityId;
		}
		set
		{
			_eadExtraActivityId = value;
		}
	}
	
	public System.Int64? EADSchoolId
	{
		get
		{
			return _eadSchoolId;
		}
		set
		{
			_eadSchoolId = value;
		}
	}
	
	public System.Int64? EADSchoolSubId
	{
		get
		{
			return _eadSchoolSubId;
		}
		set
		{
			_eadSchoolSubId = value;
		}
	}
	
	public System.String EADExamTerm
	{
		get
		{
			return _eadExamTerm;
		}
		set
		{
			_eadExamTerm = value;
		}
	}
	
	public System.String EADExtraActivity1
	{
		get
		{
			return _eadExtraActivity1;
		}
		set
		{
			_eadExtraActivity1 = value;
		}
	}
	
	public System.String EADExtraActivity2
	{
		get
		{
			return _eadExtraActivity2;
		}
		set
		{
			_eadExtraActivity2 = value;
		}
	}
	
	public System.String EADRemarks
	{
		get
		{
			return _eadRemarks;
		}
		set
		{
			_eadRemarks = value;
		}
	}
	
	public System.String EADAddeByType
	{
		get
		{
			return _eadAddeByType;
		}
		set
		{
			_eadAddeByType = value;
		}
	}
	
	public System.Int64? EADAddedById
	{
		get
		{
			return _eadAddedById;
		}
		set
		{
			_eadAddedById = value;
		}
	}
	
	public System.DateTime? EADDate
	{
		get
		{
			return _eadDate;
		}
		set
		{
			_eadDate = value;
		}
	}
	
	public System.Int32? EADStatus
	{
		get
		{
			return _eadStatus;
		}
		set
		{
			_eadStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("EAD_TimelineId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_ProgressType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_ExtraActivityId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_ExamTerm", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_ExtraActivity1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_ExtraActivity2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_Remarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_AddeByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EADTimelineId == null)
		dr["EAD_TimelineId"] = DBNull.Value;
		else
		dr["EAD_TimelineId"] = EADTimelineId;
		
		if (EADFacultyLoginId == null)
		dr["EAD_FacultyLoginId"] = DBNull.Value;
		else
		dr["EAD_FacultyLoginId"] = EADFacultyLoginId;
		
		if (EADStudentLoginId == null)
		dr["EAD_StudentLoginId"] = DBNull.Value;
		else
		dr["EAD_StudentLoginId"] = EADStudentLoginId;
		
		if (EADProgressType == null)
		dr["EAD_ProgressType"] = DBNull.Value;
		else
		dr["EAD_ProgressType"] = EADProgressType;
		
		if (EADExtraActivityId == null)
		dr["EAD_ExtraActivityId"] = DBNull.Value;
		else
		dr["EAD_ExtraActivityId"] = EADExtraActivityId;
		
		if (EADSchoolId == null)
		dr["EAD_SchoolId"] = DBNull.Value;
		else
		dr["EAD_SchoolId"] = EADSchoolId;
		
		if (EADSchoolSubId == null)
		dr["EAD_SchoolSubId"] = DBNull.Value;
		else
		dr["EAD_SchoolSubId"] = EADSchoolSubId;
		
		if (EADExamTerm == null)
		dr["EAD_ExamTerm"] = DBNull.Value;
		else
		dr["EAD_ExamTerm"] = EADExamTerm;
		
		if (EADExtraActivity1 == null)
		dr["EAD_ExtraActivity1"] = DBNull.Value;
		else
		dr["EAD_ExtraActivity1"] = EADExtraActivity1;
		
		if (EADExtraActivity2 == null)
		dr["EAD_ExtraActivity2"] = DBNull.Value;
		else
		dr["EAD_ExtraActivity2"] = EADExtraActivity2;
		
		if (EADRemarks == null)
		dr["EAD_Remarks"] = DBNull.Value;
		else
		dr["EAD_Remarks"] = EADRemarks;
		
		if (EADAddeByType == null)
		dr["EAD_AddeByType"] = DBNull.Value;
		else
		dr["EAD_AddeByType"] = EADAddeByType;
		
		if (EADAddedById == null)
		dr["EAD_AddedById"] = DBNull.Value;
		else
		dr["EAD_AddedById"] = EADAddedById;
		
		if (EADDate == null)
		dr["EAD_Date"] = DBNull.Value;
		else
		dr["EAD_Date"] = EADDate;
		
		if (EADStatus == null)
		dr["EAD_Status"] = DBNull.Value;
		else
		dr["EAD_Status"] = EADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EADTimelineId = dr["EAD_TimelineId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_TimelineId"]) : EADTimelineId = null;
		EADFacultyLoginId = dr["EAD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_FacultyLoginId"]) : EADFacultyLoginId = null;
		EADStudentLoginId = dr["EAD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_StudentLoginId"]) : EADStudentLoginId = null;
		EADProgressType = dr["EAD_ProgressType"] != DBNull.Value ? Convert.ToString(dr["EAD_ProgressType"]) : EADProgressType = null;
		EADExtraActivityId = dr["EAD_ExtraActivityId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_ExtraActivityId"]) : EADExtraActivityId = null;
		EADSchoolId = dr["EAD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_SchoolId"]) : EADSchoolId = null;
		EADSchoolSubId = dr["EAD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["EAD_SchoolSubId"]) : EADSchoolSubId = null;
		EADExamTerm = dr["EAD_ExamTerm"] != DBNull.Value ? Convert.ToString(dr["EAD_ExamTerm"]) : EADExamTerm = null;
		EADExtraActivity1 = dr["EAD_ExtraActivity1"] != DBNull.Value ? Convert.ToString(dr["EAD_ExtraActivity1"]) : EADExtraActivity1 = null;
		EADExtraActivity2 = dr["EAD_ExtraActivity2"] != DBNull.Value ? Convert.ToString(dr["EAD_ExtraActivity2"]) : EADExtraActivity2 = null;
		EADRemarks = dr["EAD_Remarks"] != DBNull.Value ? Convert.ToString(dr["EAD_Remarks"]) : EADRemarks = null;
		EADAddeByType = dr["EAD_AddeByType"] != DBNull.Value ? Convert.ToString(dr["EAD_AddeByType"]) : EADAddeByType = null;
		EADAddedById = dr["EAD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["EAD_AddedById"]) : EADAddedById = null;
		EADDate = dr["EAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EAD_Date"]) : EADDate = null;
		EADStatus = dr["EAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["EAD_Status"]) : EADStatus = null;
	}
	
	public static TMSExtraActivityDetails[] MapFrom(DataSet ds)
	{
		List<TMSExtraActivityDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExtraActivityDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExtraActivityDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExtraActivityDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExtraActivityDetails instance = new TMSExtraActivityDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivityDetails Get(System.Int64 eadTimelineId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExtraActivityDetails instance;
		
		
		instance = new TMSExtraActivityDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, eadTimelineId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSExtraActivityDetails ID:" + eadTimelineId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, eadFacultyLoginId, eadStudentLoginId, eadProgressType, eadExtraActivityId, eadSchoolId, eadSchoolSubId, eadExamTerm, eadExtraActivity1, eadExtraActivity2, eadRemarks, eadAddeByType, eadAddedById, eadDate, eadStatus);
		
		if (transaction == null)
		this.EADTimelineId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.EADTimelineId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus)
	{
		Insert(eadFacultyLoginId, eadStudentLoginId, eadProgressType, eadExtraActivityId, eadSchoolId, eadSchoolSubId, eadExamTerm, eadExtraActivity1, eadExtraActivity2, eadRemarks, eadAddeByType, eadAddedById, eadDate, eadStatus, null);
	}
	/// <summary>
	/// Insert current TMSExtraActivityDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EADFacultyLoginId, EADStudentLoginId, EADProgressType, EADExtraActivityId, EADSchoolId, EADSchoolSubId, EADExamTerm, EADExtraActivity1, EADExtraActivity2, EADRemarks, EADAddeByType, EADAddedById, EADDate, EADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExtraActivityDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? eadTimelineId, System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@eadTimelineId"].Value = eadTimelineId;
		dbCommand.Parameters["@eadFacultyLoginId"].Value = eadFacultyLoginId;
		dbCommand.Parameters["@eadStudentLoginId"].Value = eadStudentLoginId;
		dbCommand.Parameters["@eadProgressType"].Value = eadProgressType;
		dbCommand.Parameters["@eadExtraActivityId"].Value = eadExtraActivityId;
		dbCommand.Parameters["@eadSchoolId"].Value = eadSchoolId;
		dbCommand.Parameters["@eadSchoolSubId"].Value = eadSchoolSubId;
		dbCommand.Parameters["@eadExamTerm"].Value = eadExamTerm;
		dbCommand.Parameters["@eadExtraActivity1"].Value = eadExtraActivity1;
		dbCommand.Parameters["@eadExtraActivity2"].Value = eadExtraActivity2;
		dbCommand.Parameters["@eadRemarks"].Value = eadRemarks;
		dbCommand.Parameters["@eadAddeByType"].Value = eadAddeByType;
		dbCommand.Parameters["@eadAddedById"].Value = eadAddedById;
		dbCommand.Parameters["@eadDate"].Value = eadDate;
		dbCommand.Parameters["@eadStatus"].Value = eadStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? eadTimelineId, System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus)
	{
		Update(eadTimelineId, eadFacultyLoginId, eadStudentLoginId, eadProgressType, eadExtraActivityId, eadSchoolId, eadSchoolSubId, eadExamTerm, eadExtraActivity1, eadExtraActivity2, eadRemarks, eadAddeByType, eadAddedById, eadDate, eadStatus, null);
	}
	
	public static void Update(TMSExtraActivityDetails tMSExtraActivityDetails)
	{
		tMSExtraActivityDetails.Update();
	}
	
	public static void Update(TMSExtraActivityDetails tMSExtraActivityDetails, DbTransaction transaction)
	{
		tMSExtraActivityDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@eadTimelineId"].SourceColumn = "EAD_TimelineId";
		dbCommand.Parameters["@eadFacultyLoginId"].SourceColumn = "EAD_FacultyLoginId";
		dbCommand.Parameters["@eadStudentLoginId"].SourceColumn = "EAD_StudentLoginId";
		dbCommand.Parameters["@eadProgressType"].SourceColumn = "EAD_ProgressType";
		dbCommand.Parameters["@eadExtraActivityId"].SourceColumn = "EAD_ExtraActivityId";
		dbCommand.Parameters["@eadSchoolId"].SourceColumn = "EAD_SchoolId";
		dbCommand.Parameters["@eadSchoolSubId"].SourceColumn = "EAD_SchoolSubId";
		dbCommand.Parameters["@eadExamTerm"].SourceColumn = "EAD_ExamTerm";
		dbCommand.Parameters["@eadExtraActivity1"].SourceColumn = "EAD_ExtraActivity1";
		dbCommand.Parameters["@eadExtraActivity2"].SourceColumn = "EAD_ExtraActivity2";
		dbCommand.Parameters["@eadRemarks"].SourceColumn = "EAD_Remarks";
		dbCommand.Parameters["@eadAddeByType"].SourceColumn = "EAD_AddeByType";
		dbCommand.Parameters["@eadAddedById"].SourceColumn = "EAD_AddedById";
		dbCommand.Parameters["@eadDate"].SourceColumn = "EAD_Date";
		dbCommand.Parameters["@eadStatus"].SourceColumn = "EAD_Status";
		
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
	public static void Delete(System.Int64? eadTimelineId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, eadTimelineId);
		
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
	public static void Delete(System.Int64? eadTimelineId)
	{
		Delete(
		eadTimelineId);
	}
	
	/// <summary>
	/// Delete current TMSExtraActivityDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EADTimelineId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EADTimelineId = null;
	}
	
	/// <summary>
	/// Delete current TMSExtraActivityDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivityDetails[] Search(System.Int64? eadTimelineId, System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, eadTimelineId, eadFacultyLoginId, eadStudentLoginId, eadProgressType, eadExtraActivityId, eadSchoolId, eadSchoolSubId, eadExamTerm, eadExtraActivity1, eadExtraActivity2, eadRemarks, eadAddeByType, eadAddedById, eadDate, eadStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExtraActivityDetails.MapFrom(ds);
	}
	
	
	public static TMSExtraActivityDetails[] Search(TMSExtraActivityDetails searchObject)
	{
		return Search ( searchObject.EADTimelineId, searchObject.EADFacultyLoginId, searchObject.EADStudentLoginId, searchObject.EADProgressType, searchObject.EADExtraActivityId, searchObject.EADSchoolId, searchObject.EADSchoolSubId, searchObject.EADExamTerm, searchObject.EADExtraActivity1, searchObject.EADExtraActivity2, searchObject.EADRemarks, searchObject.EADAddeByType, searchObject.EADAddedById, searchObject.EADDate, searchObject.EADStatus);
	}
	
	/// <summary>
	/// Returns all TMSExtraActivityDetails objects.
	/// </summary>
	/// <returns>List of all TMSExtraActivityDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExtraActivityDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

