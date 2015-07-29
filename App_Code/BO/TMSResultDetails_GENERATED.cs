/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/13/2012 9:57:15 AM                                    */
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
public partial class TMSResultDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ResultDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _rdResultId;
	private System.Int64? _rdSchoolId;
	private System.Int64? _rdSchoolSubId;
	private System.Int64? _rdStudentId;
	private System.Int64? _rdSubjectId;
	private System.String _rdExamType;
	private System.Int64? _rdExamId;
	private System.String _rdExamName;
	private System.String _rdResultText;
	private System.Int32? _rdMarks;
	private System.String _rdGrade;
	private System.DateTime? _rdResultDate;
	private System.Int64? _rdResultAddedBy;
	private System.String _rdResultStatus;
	private System.DateTime? _rdDate;
	private System.Int32? _rdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? RDResultId
	{
		get
		{
			return _rdResultId;
		}
		set
		{
			_rdResultId = value;
		}
	}
	
	public System.Int64? RDSchoolId
	{
		get
		{
			return _rdSchoolId;
		}
		set
		{
			_rdSchoolId = value;
		}
	}
	
	public System.Int64? RDSchoolSubId
	{
		get
		{
			return _rdSchoolSubId;
		}
		set
		{
			_rdSchoolSubId = value;
		}
	}
	
	public System.Int64? RDStudentId
	{
		get
		{
			return _rdStudentId;
		}
		set
		{
			_rdStudentId = value;
		}
	}
	
	public System.Int64? RDSubjectId
	{
		get
		{
			return _rdSubjectId;
		}
		set
		{
			_rdSubjectId = value;
		}
	}
	
	public System.String RDExamType
	{
		get
		{
			return _rdExamType;
		}
		set
		{
			_rdExamType = value;
		}
	}
	
	public System.Int64? RDExamId
	{
		get
		{
			return _rdExamId;
		}
		set
		{
			_rdExamId = value;
		}
	}
	
	public System.String RDExamName
	{
		get
		{
			return _rdExamName;
		}
		set
		{
			_rdExamName = value;
		}
	}
	
	public System.String RDResultText
	{
		get
		{
			return _rdResultText;
		}
		set
		{
			_rdResultText = value;
		}
	}
	
	public System.Int32? RDMarks
	{
		get
		{
			return _rdMarks;
		}
		set
		{
			_rdMarks = value;
		}
	}
	
	public System.String RDGrade
	{
		get
		{
			return _rdGrade;
		}
		set
		{
			_rdGrade = value;
		}
	}
	
	public System.DateTime? RDResultDate
	{
		get
		{
			return _rdResultDate;
		}
		set
		{
			_rdResultDate = value;
		}
	}
	
	public System.Int64? RDResultAddedBy
	{
		get
		{
			return _rdResultAddedBy;
		}
		set
		{
			_rdResultAddedBy = value;
		}
	}
	
	public System.String RDResultStatus
	{
		get
		{
			return _rdResultStatus;
		}
		set
		{
			_rdResultStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("RD_ResultId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ExamType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ExamId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ExamName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ResultText", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Marks", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Grade", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ResultDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ResultAddedBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_ResultStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("RD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (RDResultId == null)
		dr["RD_ResultId"] = DBNull.Value;
		else
		dr["RD_ResultId"] = RDResultId;
		
		if (RDSchoolId == null)
		dr["RD_SchoolId"] = DBNull.Value;
		else
		dr["RD_SchoolId"] = RDSchoolId;
		
		if (RDSchoolSubId == null)
		dr["RD_SchoolSubId"] = DBNull.Value;
		else
		dr["RD_SchoolSubId"] = RDSchoolSubId;
		
		if (RDStudentId == null)
		dr["RD_StudentId"] = DBNull.Value;
		else
		dr["RD_StudentId"] = RDStudentId;
		
		if (RDSubjectId == null)
		dr["RD_SubjectId"] = DBNull.Value;
		else
		dr["RD_SubjectId"] = RDSubjectId;
		
		if (RDExamType == null)
		dr["RD_ExamType"] = DBNull.Value;
		else
		dr["RD_ExamType"] = RDExamType;
		
		if (RDExamId == null)
		dr["RD_ExamId"] = DBNull.Value;
		else
		dr["RD_ExamId"] = RDExamId;
		
		if (RDExamName == null)
		dr["RD_ExamName"] = DBNull.Value;
		else
		dr["RD_ExamName"] = RDExamName;
		
		if (RDResultText == null)
		dr["RD_ResultText"] = DBNull.Value;
		else
		dr["RD_ResultText"] = RDResultText;
		
		if (RDMarks == null)
		dr["RD_Marks"] = DBNull.Value;
		else
		dr["RD_Marks"] = RDMarks;
		
		if (RDGrade == null)
		dr["RD_Grade"] = DBNull.Value;
		else
		dr["RD_Grade"] = RDGrade;
		
		if (RDResultDate == null)
		dr["RD_ResultDate"] = DBNull.Value;
		else
		dr["RD_ResultDate"] = RDResultDate;
		
		if (RDResultAddedBy == null)
		dr["RD_ResultAddedBy"] = DBNull.Value;
		else
		dr["RD_ResultAddedBy"] = RDResultAddedBy;
		
		if (RDResultStatus == null)
		dr["RD_ResultStatus"] = DBNull.Value;
		else
		dr["RD_ResultStatus"] = RDResultStatus;
		
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
		RDResultId = dr["RD_ResultId"] != DBNull.Value ? Convert.ToInt64(dr["RD_ResultId"]) : RDResultId = null;
		RDSchoolId = dr["RD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["RD_SchoolId"]) : RDSchoolId = null;
		RDSchoolSubId = dr["RD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["RD_SchoolSubId"]) : RDSchoolSubId = null;
		RDStudentId = dr["RD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["RD_StudentId"]) : RDStudentId = null;
		RDSubjectId = dr["RD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["RD_SubjectId"]) : RDSubjectId = null;
		RDExamType = dr["RD_ExamType"] != DBNull.Value ? Convert.ToString(dr["RD_ExamType"]) : RDExamType = null;
		RDExamId = dr["RD_ExamId"] != DBNull.Value ? Convert.ToInt64(dr["RD_ExamId"]) : RDExamId = null;
		RDExamName = dr["RD_ExamName"] != DBNull.Value ? Convert.ToString(dr["RD_ExamName"]) : RDExamName = null;
		RDResultText = dr["RD_ResultText"] != DBNull.Value ? Convert.ToString(dr["RD_ResultText"]) : RDResultText = null;
		RDMarks = dr["RD_Marks"] != DBNull.Value ? Convert.ToInt32(dr["RD_Marks"]) : RDMarks = null;
		RDGrade = dr["RD_Grade"] != DBNull.Value ? Convert.ToString(dr["RD_Grade"]) : RDGrade = null;
		RDResultDate = dr["RD_ResultDate"] != DBNull.Value ? Convert.ToDateTime(dr["RD_ResultDate"]) : RDResultDate = null;
		RDResultAddedBy = dr["RD_ResultAddedBy"] != DBNull.Value ? Convert.ToInt64(dr["RD_ResultAddedBy"]) : RDResultAddedBy = null;
		RDResultStatus = dr["RD_ResultStatus"] != DBNull.Value ? Convert.ToString(dr["RD_ResultStatus"]) : RDResultStatus = null;
		RDDate = dr["RD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["RD_Date"]) : RDDate = null;
		RDStatus = dr["RD_Status"] != DBNull.Value ? Convert.ToInt32(dr["RD_Status"]) : RDStatus = null;
	}
	
	public static TMSResultDetails[] MapFrom(DataSet ds)
	{
		List<TMSResultDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSResultDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ResultDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ResultDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSResultDetails instance = new TMSResultDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSResultDetails Get(System.Int64 rdResultId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSResultDetails instance;
		
		
		instance = new TMSResultDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdResultId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSResultDetails ID:" + rdResultId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdSchoolId, rdSchoolSubId, rdStudentId, rdSubjectId, rdExamType, rdExamId, rdExamName, rdResultText, rdMarks, rdGrade, rdResultDate, rdResultAddedBy, rdResultStatus, rdDate, rdStatus);
		
		if (transaction == null)
		this.RDResultId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.RDResultId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Insert(rdSchoolId, rdSchoolSubId, rdStudentId, rdSubjectId, rdExamType, rdExamId, rdExamName, rdResultText, rdMarks, rdGrade, rdResultDate, rdResultAddedBy, rdResultStatus, rdDate, rdStatus, null);
	}
	/// <summary>
	/// Insert current TMSResultDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(RDSchoolId, RDSchoolSubId, RDStudentId, RDSubjectId, RDExamType, RDExamId, RDExamName, RDResultText, RDMarks, RDGrade, RDResultDate, RDResultAddedBy, RDResultStatus, RDDate, RDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSResultDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? rdResultId, System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdResultId"].Value = rdResultId;
		dbCommand.Parameters["@rdSchoolId"].Value = rdSchoolId;
		dbCommand.Parameters["@rdSchoolSubId"].Value = rdSchoolSubId;
		dbCommand.Parameters["@rdStudentId"].Value = rdStudentId;
		dbCommand.Parameters["@rdSubjectId"].Value = rdSubjectId;
		dbCommand.Parameters["@rdExamType"].Value = rdExamType;
		dbCommand.Parameters["@rdExamId"].Value = rdExamId;
		dbCommand.Parameters["@rdExamName"].Value = rdExamName;
		dbCommand.Parameters["@rdResultText"].Value = rdResultText;
		dbCommand.Parameters["@rdMarks"].Value = rdMarks;
		dbCommand.Parameters["@rdGrade"].Value = rdGrade;
		dbCommand.Parameters["@rdResultDate"].Value = rdResultDate;
		dbCommand.Parameters["@rdResultAddedBy"].Value = rdResultAddedBy;
		dbCommand.Parameters["@rdResultStatus"].Value = rdResultStatus;
		dbCommand.Parameters["@rdDate"].Value = rdDate;
		dbCommand.Parameters["@rdStatus"].Value = rdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? rdResultId, System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		Update(rdResultId, rdSchoolId, rdSchoolSubId, rdStudentId, rdSubjectId, rdExamType, rdExamId, rdExamName, rdResultText, rdMarks, rdGrade, rdResultDate, rdResultAddedBy, rdResultStatus, rdDate, rdStatus, null);
	}
	
	public static void Update(TMSResultDetails tMSResultDetails)
	{
		tMSResultDetails.Update();
	}
	
	public static void Update(TMSResultDetails tMSResultDetails, DbTransaction transaction)
	{
		tMSResultDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSResultDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@rdResultId"].SourceColumn = "RD_ResultId";
		dbCommand.Parameters["@rdSchoolId"].SourceColumn = "RD_SchoolId";
		dbCommand.Parameters["@rdSchoolSubId"].SourceColumn = "RD_SchoolSubId";
		dbCommand.Parameters["@rdStudentId"].SourceColumn = "RD_StudentId";
		dbCommand.Parameters["@rdSubjectId"].SourceColumn = "RD_SubjectId";
		dbCommand.Parameters["@rdExamType"].SourceColumn = "RD_ExamType";
		dbCommand.Parameters["@rdExamId"].SourceColumn = "RD_ExamId";
		dbCommand.Parameters["@rdExamName"].SourceColumn = "RD_ExamName";
		dbCommand.Parameters["@rdResultText"].SourceColumn = "RD_ResultText";
		dbCommand.Parameters["@rdMarks"].SourceColumn = "RD_Marks";
		dbCommand.Parameters["@rdGrade"].SourceColumn = "RD_Grade";
		dbCommand.Parameters["@rdResultDate"].SourceColumn = "RD_ResultDate";
		dbCommand.Parameters["@rdResultAddedBy"].SourceColumn = "RD_ResultAddedBy";
		dbCommand.Parameters["@rdResultStatus"].SourceColumn = "RD_ResultStatus";
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
	public static void Delete(System.Int64? rdResultId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdResultId);
		
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
	public static void Delete(System.Int64? rdResultId)
	{
		Delete(
		rdResultId);
	}
	
	/// <summary>
	/// Delete current TMSResultDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, RDResultId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.RDResultId = null;
	}
	
	/// <summary>
	/// Delete current TMSResultDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSResultDetails[] Search(System.Int64? rdResultId, System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSResultDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdResultId, rdSchoolId, rdSchoolSubId, rdStudentId, rdSubjectId, rdExamType, rdExamId, rdExamName, rdResultText, rdMarks, rdGrade, rdResultDate, rdResultAddedBy, rdResultStatus, rdDate, rdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSResultDetails.MapFrom(ds);
	}
	
	
	public static TMSResultDetails[] Search(TMSResultDetails searchObject)
	{
		return Search ( searchObject.RDResultId, searchObject.RDSchoolId, searchObject.RDSchoolSubId, searchObject.RDStudentId, searchObject.RDSubjectId, searchObject.RDExamType, searchObject.RDExamId, searchObject.RDExamName, searchObject.RDResultText, searchObject.RDMarks, searchObject.RDGrade, searchObject.RDResultDate, searchObject.RDResultAddedBy, searchObject.RDResultStatus, searchObject.RDDate, searchObject.RDStatus);
	}
	
	/// <summary>
	/// Returns all TMSResultDetails objects.
	/// </summary>
	/// <returns>List of all TMSResultDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSResultDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

