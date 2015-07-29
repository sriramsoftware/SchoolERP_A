/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/4/2012 11:20:41 AM                                    */
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
public partial class TMSExamDetails
{
	

	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExamDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _edExamDetailsId;
	private System.String _edExamCode;
	private System.Int64? _edFacultyId;
	private System.Int64? _edFacultyLoginId;
	private System.String _edExamType;
	private System.Int64? _edUnitTestId;
	private System.Int64? _edSchoolId;
	private System.Int64? _edSchoolSubId;
	private System.Int64? _edSubjectId;
	private System.Int64? _edConductFacultyId;
	private System.Int64? _edDepartmentID;
	private System.String _edExtraDescription;
	private System.String _edClasstestTitle;
	private System.String _edExtra1;
	private System.DateTime? _edExamDate;
	private System.String _edStartTime;
	private System.String _edEndTime;
	private System.String _edExamFees;
	private System.String _edTotalMarks;
	private System.String _edPassingMarks;
	private System.DateTime? _edDate;
	private System.Int32? _edStatus;
	private System.String _edTitle;
	private System.String _edTitle1;
	
	#endregion
	
	
	#region Properties
	public System.Int64? EDExamDetailsId
	{
		get
		{
			return _edExamDetailsId;
		}
		set
		{
			_edExamDetailsId = value;
		}
	}
	
	public System.String EDExamCode
	{
		get
		{
			return _edExamCode;
		}
		set
		{
			_edExamCode = value;
		}
	}
	
	public System.Int64? EDFacultyId
	{
		get
		{
			return _edFacultyId;
		}
		set
		{
			_edFacultyId = value;
		}
	}
	
	public System.Int64? EDFacultyLoginId
	{
		get
		{
			return _edFacultyLoginId;
		}
		set
		{
			_edFacultyLoginId = value;
		}
	}
	
	public System.String EDExamType
	{
		get
		{
			return _edExamType;
		}
		set
		{
			_edExamType = value;
		}
	}
	
	public System.Int64? EDUnitTestId
	{
		get
		{
			return _edUnitTestId;
		}
		set
		{
			_edUnitTestId = value;
		}
	}
	
	public System.Int64? EDSchoolId
	{
		get
		{
			return _edSchoolId;
		}
		set
		{
			_edSchoolId = value;
		}
	}
	
	public System.Int64? EDSchoolSubId
	{
		get
		{
			return _edSchoolSubId;
		}
		set
		{
			_edSchoolSubId = value;
		}
	}
	
	public System.Int64? EDSubjectId
	{
		get
		{
			return _edSubjectId;
		}
		set
		{
			_edSubjectId = value;
		}
	}
	
	public System.Int64? EDConductFacultyId
	{
		get
		{
			return _edConductFacultyId;
		}
		set
		{
			_edConductFacultyId = value;
		}
	}
	
	public System.Int64? EDDepartmentID
	{
		get
		{
			return _edDepartmentID;
		}
		set
		{
			_edDepartmentID = value;
		}
	}
	
	public System.String EDExtraDescription
	{
		get
		{
			return _edExtraDescription;
		}
		set
		{
			_edExtraDescription = value;
		}
	}
	
	public System.String EDClasstestTitle
	{
		get
		{
			return _edClasstestTitle;
		}
		set
		{
			_edClasstestTitle = value;
		}
	}
	
	public System.String EDExtra1
	{
		get
		{
			return _edExtra1;
		}
		set
		{
			_edExtra1 = value;
		}
	}
	
	public System.DateTime? EDExamDate
	{
		get
		{
			return _edExamDate;
		}
		set
		{
			_edExamDate = value;
		}
	}
	
	public System.String EDStartTime
	{
		get
		{
			return _edStartTime;
		}
		set
		{
			_edStartTime = value;
		}
	}
	
	public System.String EDEndTime
	{
		get
		{
			return _edEndTime;
		}
		set
		{
			_edEndTime = value;
		}
	}
	
	public System.String EDExamFees
	{
		get
		{
			return _edExamFees;
		}
		set
		{
			_edExamFees = value;
		}
	}
	
	public System.String EDTotalMarks
	{
		get
		{
			return _edTotalMarks;
		}
		set
		{
			_edTotalMarks = value;
		}
	}
	
	public System.String EDPassingMarks
	{
		get
		{
			return _edPassingMarks;
		}
		set
		{
			_edPassingMarks = value;
		}
	}
	
	public System.DateTime? EDDate
	{
		get
		{
			return _edDate;
		}
		set
		{
			_edDate = value;
		}
	}
	
	public System.Int32? EDStatus
	{
		get
		{
			return _edStatus;
		}
		set
		{
			_edStatus = value;
		}
	}
	
	public System.String EDTitle
	{
		get
		{
			return _edTitle;
		}
		set
		{
			_edTitle = value;
		}
	}
	
	public System.String EDTitle1
	{
		get
		{
			return _edTitle1;
		}
		set
		{
			_edTitle1 = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExamDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExamCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExamType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_UnitTestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ConductFacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_DepartmentID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExtraDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ClasstestTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExamDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_StartTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_EndTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_ExamFees", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_TotalMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_PassingMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_Status", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ED_Title1", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EDExamDetailsId == null)
		dr["ED_ExamDetailsId"] = DBNull.Value;
		else
		dr["ED_ExamDetailsId"] = EDExamDetailsId;
		
		if (EDExamCode == null)
		dr["ED_ExamCode"] = DBNull.Value;
		else
		dr["ED_ExamCode"] = EDExamCode;
		
		if (EDFacultyId == null)
		dr["ED_FacultyId"] = DBNull.Value;
		else
		dr["ED_FacultyId"] = EDFacultyId;
		
		if (EDFacultyLoginId == null)
		dr["ED_FacultyLoginId"] = DBNull.Value;
		else
		dr["ED_FacultyLoginId"] = EDFacultyLoginId;
		
		if (EDExamType == null)
		dr["ED_ExamType"] = DBNull.Value;
		else
		dr["ED_ExamType"] = EDExamType;
		
		if (EDUnitTestId == null)
		dr["ED_UnitTestId"] = DBNull.Value;
		else
		dr["ED_UnitTestId"] = EDUnitTestId;
		
		if (EDSchoolId == null)
		dr["ED_SchoolId"] = DBNull.Value;
		else
		dr["ED_SchoolId"] = EDSchoolId;
		
		if (EDSchoolSubId == null)
		dr["ED_SchoolSubId"] = DBNull.Value;
		else
		dr["ED_SchoolSubId"] = EDSchoolSubId;
		
		if (EDSubjectId == null)
		dr["ED_SubjectId"] = DBNull.Value;
		else
		dr["ED_SubjectId"] = EDSubjectId;
		
		if (EDConductFacultyId == null)
		dr["ED_ConductFacultyId"] = DBNull.Value;
		else
		dr["ED_ConductFacultyId"] = EDConductFacultyId;
		
		if (EDDepartmentID == null)
		dr["ED_DepartmentID"] = DBNull.Value;
		else
		dr["ED_DepartmentID"] = EDDepartmentID;
		
		if (EDExtraDescription == null)
		dr["ED_ExtraDescription"] = DBNull.Value;
		else
		dr["ED_ExtraDescription"] = EDExtraDescription;
		
		if (EDClasstestTitle == null)
		dr["ED_ClasstestTitle"] = DBNull.Value;
		else
		dr["ED_ClasstestTitle"] = EDClasstestTitle;
		
		if (EDExtra1 == null)
		dr["ED_Extra1"] = DBNull.Value;
		else
		dr["ED_Extra1"] = EDExtra1;
		
		if (EDExamDate == null)
		dr["ED_ExamDate"] = DBNull.Value;
		else
		dr["ED_ExamDate"] = EDExamDate;
		
		if (EDStartTime == null)
		dr["ED_StartTime"] = DBNull.Value;
		else
		dr["ED_StartTime"] = EDStartTime;
		
		if (EDEndTime == null)
		dr["ED_EndTime"] = DBNull.Value;
		else
		dr["ED_EndTime"] = EDEndTime;
		
		if (EDExamFees == null)
		dr["ED_ExamFees"] = DBNull.Value;
		else
		dr["ED_ExamFees"] = EDExamFees;
		
		if (EDTotalMarks == null)
		dr["ED_TotalMarks"] = DBNull.Value;
		else
		dr["ED_TotalMarks"] = EDTotalMarks;
		
		if (EDPassingMarks == null)
		dr["ED_PassingMarks"] = DBNull.Value;
		else
		dr["ED_PassingMarks"] = EDPassingMarks;
		
		if (EDDate == null)
		dr["ED_Date"] = DBNull.Value;
		else
		dr["ED_Date"] = EDDate;
		
		if (EDStatus == null)
		dr["ED_Status"] = DBNull.Value;
		else
		dr["ED_Status"] = EDStatus;
		
		if (EDTitle == null)
		dr["ED_Title"] = DBNull.Value;
		else
		dr["ED_Title"] = EDTitle;
		
		if (EDTitle1 == null)
		dr["ED_Title1"] = DBNull.Value;
		else
		dr["ED_Title1"] = EDTitle1;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EDExamDetailsId = dr["ED_ExamDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["ED_ExamDetailsId"]) : EDExamDetailsId = null;
		EDExamCode = dr["ED_ExamCode"] != DBNull.Value ? Convert.ToString(dr["ED_ExamCode"]) : EDExamCode = null;
		EDFacultyId = dr["ED_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["ED_FacultyId"]) : EDFacultyId = null;
		EDFacultyLoginId = dr["ED_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ED_FacultyLoginId"]) : EDFacultyLoginId = null;
		EDExamType = dr["ED_ExamType"] != DBNull.Value ? Convert.ToString(dr["ED_ExamType"]) : EDExamType = null;
		EDUnitTestId = dr["ED_UnitTestId"] != DBNull.Value ? Convert.ToInt64(dr["ED_UnitTestId"]) : EDUnitTestId = null;
		EDSchoolId = dr["ED_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ED_SchoolId"]) : EDSchoolId = null;
		EDSchoolSubId = dr["ED_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ED_SchoolSubId"]) : EDSchoolSubId = null;
		EDSubjectId = dr["ED_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["ED_SubjectId"]) : EDSubjectId = null;
		EDConductFacultyId = dr["ED_ConductFacultyId"] != DBNull.Value ? Convert.ToInt64(dr["ED_ConductFacultyId"]) : EDConductFacultyId = null;
		EDDepartmentID = dr["ED_DepartmentID"] != DBNull.Value ? Convert.ToInt64(dr["ED_DepartmentID"]) : EDDepartmentID = null;
		EDExtraDescription = dr["ED_ExtraDescription"] != DBNull.Value ? Convert.ToString(dr["ED_ExtraDescription"]) : EDExtraDescription = null;
		EDClasstestTitle = dr["ED_ClasstestTitle"] != DBNull.Value ? Convert.ToString(dr["ED_ClasstestTitle"]) : EDClasstestTitle = null;
		EDExtra1 = dr["ED_Extra1"] != DBNull.Value ? Convert.ToString(dr["ED_Extra1"]) : EDExtra1 = null;
		EDExamDate = dr["ED_ExamDate"] != DBNull.Value ? Convert.ToDateTime(dr["ED_ExamDate"]) : EDExamDate = null;
		EDStartTime = dr["ED_StartTime"] != DBNull.Value ? Convert.ToString(dr["ED_StartTime"]) : EDStartTime = null;
		EDEndTime = dr["ED_EndTime"] != DBNull.Value ? Convert.ToString(dr["ED_EndTime"]) : EDEndTime = null;
		EDExamFees = dr["ED_ExamFees"] != DBNull.Value ? Convert.ToString(dr["ED_ExamFees"]) : EDExamFees = null;
		EDTotalMarks = dr["ED_TotalMarks"] != DBNull.Value ? Convert.ToString(dr["ED_TotalMarks"]) : EDTotalMarks = null;
		EDPassingMarks = dr["ED_PassingMarks"] != DBNull.Value ? Convert.ToString(dr["ED_PassingMarks"]) : EDPassingMarks = null;
		EDDate = dr["ED_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ED_Date"]) : EDDate = null;
		EDStatus = dr["ED_Status"] != DBNull.Value ? Convert.ToInt32(dr["ED_Status"]) : EDStatus = null;
		EDTitle = dr["ED_Title"] != DBNull.Value ? Convert.ToString(dr["ED_Title"]) : EDTitle = null;
		EDTitle1 = dr["ED_Title1"] != DBNull.Value ? Convert.ToString(dr["ED_Title1"]) : EDTitle1 = null;
	}
	
	public static TMSExamDetails[] MapFrom(DataSet ds)
	{
		List<TMSExamDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExamDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExamDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExamDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExamDetails instance = new TMSExamDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamDetails Get(System.Int64 edExamDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExamDetails instance;
		
		
		instance = new TMSExamDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSExamDetails ID:" + edExamDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, edExamCode, edFacultyId, edFacultyLoginId, edExamType, edUnitTestId, edSchoolId, edSchoolSubId, edSubjectId, edConductFacultyId, edDepartmentID, edExtraDescription, edClasstestTitle, edExtra1, edExamDate, edStartTime, edEndTime, edExamFees, edTotalMarks, edPassingMarks, edDate, edStatus, edTitle, edTitle1);
		
		if (transaction == null)
		this.EDExamDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.EDExamDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1)
	{
		Insert(edExamCode, edFacultyId, edFacultyLoginId, edExamType, edUnitTestId, edSchoolId, edSchoolSubId, edSubjectId, edConductFacultyId, edDepartmentID, edExtraDescription, edClasstestTitle, edExtra1, edExamDate, edStartTime, edEndTime, edExamFees, edTotalMarks, edPassingMarks, edDate, edStatus, edTitle, edTitle1, null);
	}
	/// <summary>
	/// Insert current TMSExamDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EDExamCode, EDFacultyId, EDFacultyLoginId, EDExamType, EDUnitTestId, EDSchoolId, EDSchoolSubId, EDSubjectId, EDConductFacultyId, EDDepartmentID, EDExtraDescription, EDClasstestTitle, EDExtra1, EDExamDate, EDStartTime, EDEndTime, EDExamFees, EDTotalMarks, EDPassingMarks, EDDate, EDStatus, EDTitle, EDTitle1, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExamDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? edExamDetailsId, System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@edExamDetailsId"].Value = edExamDetailsId;
		dbCommand.Parameters["@edExamCode"].Value = edExamCode;
		dbCommand.Parameters["@edFacultyId"].Value = edFacultyId;
		dbCommand.Parameters["@edFacultyLoginId"].Value = edFacultyLoginId;
		dbCommand.Parameters["@edExamType"].Value = edExamType;
		dbCommand.Parameters["@edUnitTestId"].Value = edUnitTestId;
		dbCommand.Parameters["@edSchoolId"].Value = edSchoolId;
		dbCommand.Parameters["@edSchoolSubId"].Value = edSchoolSubId;
		dbCommand.Parameters["@edSubjectId"].Value = edSubjectId;
		dbCommand.Parameters["@edConductFacultyId"].Value = edConductFacultyId;
		dbCommand.Parameters["@edDepartmentID"].Value = edDepartmentID;
		dbCommand.Parameters["@edExtraDescription"].Value = edExtraDescription;
		dbCommand.Parameters["@edClasstestTitle"].Value = edClasstestTitle;
		dbCommand.Parameters["@edExtra1"].Value = edExtra1;
		dbCommand.Parameters["@edExamDate"].Value = edExamDate;
		dbCommand.Parameters["@edStartTime"].Value = edStartTime;
		dbCommand.Parameters["@edEndTime"].Value = edEndTime;
		dbCommand.Parameters["@edExamFees"].Value = edExamFees;
		dbCommand.Parameters["@edTotalMarks"].Value = edTotalMarks;
		dbCommand.Parameters["@edPassingMarks"].Value = edPassingMarks;
		dbCommand.Parameters["@edDate"].Value = edDate;
		dbCommand.Parameters["@edStatus"].Value = edStatus;
		dbCommand.Parameters["@edTitle"].Value = edTitle;
		dbCommand.Parameters["@edTitle1"].Value = edTitle1;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? edExamDetailsId, System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1)
	{
		Update(edExamDetailsId, edExamCode, edFacultyId, edFacultyLoginId, edExamType, edUnitTestId, edSchoolId, edSchoolSubId, edSubjectId, edConductFacultyId, edDepartmentID, edExtraDescription, edClasstestTitle, edExtra1, edExamDate, edStartTime, edEndTime, edExamFees, edTotalMarks, edPassingMarks, edDate, edStatus, edTitle, edTitle1, null);
	}
	
	public static void Update(TMSExamDetails tMSExamDetails)
	{
		tMSExamDetails.Update();
	}
	
	public static void Update(TMSExamDetails tMSExamDetails, DbTransaction transaction)
	{
		tMSExamDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExamDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@edExamDetailsId"].SourceColumn = "ED_ExamDetailsId";
		dbCommand.Parameters["@edExamCode"].SourceColumn = "ED_ExamCode";
		dbCommand.Parameters["@edFacultyId"].SourceColumn = "ED_FacultyId";
		dbCommand.Parameters["@edFacultyLoginId"].SourceColumn = "ED_FacultyLoginId";
		dbCommand.Parameters["@edExamType"].SourceColumn = "ED_ExamType";
		dbCommand.Parameters["@edUnitTestId"].SourceColumn = "ED_UnitTestId";
		dbCommand.Parameters["@edSchoolId"].SourceColumn = "ED_SchoolId";
		dbCommand.Parameters["@edSchoolSubId"].SourceColumn = "ED_SchoolSubId";
		dbCommand.Parameters["@edSubjectId"].SourceColumn = "ED_SubjectId";
		dbCommand.Parameters["@edConductFacultyId"].SourceColumn = "ED_ConductFacultyId";
		dbCommand.Parameters["@edDepartmentID"].SourceColumn = "ED_DepartmentID";
		dbCommand.Parameters["@edExtraDescription"].SourceColumn = "ED_ExtraDescription";
		dbCommand.Parameters["@edClasstestTitle"].SourceColumn = "ED_ClasstestTitle";
		dbCommand.Parameters["@edExtra1"].SourceColumn = "ED_Extra1";
		dbCommand.Parameters["@edExamDate"].SourceColumn = "ED_ExamDate";
		dbCommand.Parameters["@edStartTime"].SourceColumn = "ED_StartTime";
		dbCommand.Parameters["@edEndTime"].SourceColumn = "ED_EndTime";
		dbCommand.Parameters["@edExamFees"].SourceColumn = "ED_ExamFees";
		dbCommand.Parameters["@edTotalMarks"].SourceColumn = "ED_TotalMarks";
		dbCommand.Parameters["@edPassingMarks"].SourceColumn = "ED_PassingMarks";
		dbCommand.Parameters["@edDate"].SourceColumn = "ED_Date";
		dbCommand.Parameters["@edStatus"].SourceColumn = "ED_Status";
		dbCommand.Parameters["@edTitle"].SourceColumn = "ED_Title";
		dbCommand.Parameters["@edTitle1"].SourceColumn = "ED_Title1";
		
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
	public static void Delete(System.Int64? edExamDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId);
		
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
	public static void Delete(System.Int64? edExamDetailsId)
	{
		Delete(
		edExamDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSExamDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EDExamDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EDExamDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSExamDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamDetails[] Search(System.Int64? edExamDetailsId, System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId, edExamCode, edFacultyId, edFacultyLoginId, edExamType, edUnitTestId, edSchoolId, edSchoolSubId, edSubjectId, edConductFacultyId, edDepartmentID, edExtraDescription, edClasstestTitle, edExtra1, edExamDate, edStartTime, edEndTime, edExamFees, edTotalMarks, edPassingMarks, edDate, edStatus, edTitle, edTitle1);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExamDetails.MapFrom(ds);
	}
	
	
	public static TMSExamDetails[] Search(TMSExamDetails searchObject)
	{
		return Search ( searchObject.EDExamDetailsId, searchObject.EDExamCode, searchObject.EDFacultyId, searchObject.EDFacultyLoginId, searchObject.EDExamType, searchObject.EDUnitTestId, searchObject.EDSchoolId, searchObject.EDSchoolSubId, searchObject.EDSubjectId, searchObject.EDConductFacultyId, searchObject.EDDepartmentID, searchObject.EDExtraDescription, searchObject.EDClasstestTitle, searchObject.EDExtra1, searchObject.EDExamDate, searchObject.EDStartTime, searchObject.EDEndTime, searchObject.EDExamFees, searchObject.EDTotalMarks, searchObject.EDPassingMarks, searchObject.EDDate, searchObject.EDStatus, searchObject.EDTitle, searchObject.EDTitle1);
	}
	
	/// <summary>
	/// Returns all TMSExamDetails objects.
	/// </summary>
	/// <returns>List of all TMSExamDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExamDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

