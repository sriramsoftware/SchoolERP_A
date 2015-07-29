/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/30/2012 11:39:34 AM                                    */
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
public partial class TMSGeneralKnowledgeDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_GeneralKnowledgeDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _gkKnowledgeId;
	private System.Int64? _gkFacultyId;
	private System.Int64? _gkStudentId;
	private System.Int64? _gkSchoolId;
	private System.Int64? _gkSchoolSubId;
	private System.String _gkQuestionType;
	private System.String _gkQuestion;
	private System.String _gkAnswer;
	private System.String _gkOption1;
	private System.String _gkOption2;
	private System.String _gkOption3;
	private System.String _gkOption4;
	private System.String _gkOption5;
	private System.String _gkQuestionFor;
	private System.Int64? _gkAddedById;
	private System.DateTime? _gkTestDate;
	private System.DateTime? _gkDate;
	private System.Int32? _gkStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? GKKnowledgeId
	{
		get
		{
			return _gkKnowledgeId;
		}
		set
		{
			_gkKnowledgeId = value;
		}
	}
	
	public System.Int64? GKFacultyId
	{
		get
		{
			return _gkFacultyId;
		}
		set
		{
			_gkFacultyId = value;
		}
	}
	
	public System.Int64? GKStudentId
	{
		get
		{
			return _gkStudentId;
		}
		set
		{
			_gkStudentId = value;
		}
	}
	
	public System.Int64? GKSchoolId
	{
		get
		{
			return _gkSchoolId;
		}
		set
		{
			_gkSchoolId = value;
		}
	}
	
	public System.Int64? GKSchoolSubId
	{
		get
		{
			return _gkSchoolSubId;
		}
		set
		{
			_gkSchoolSubId = value;
		}
	}
	
	public System.String GKQuestionType
	{
		get
		{
			return _gkQuestionType;
		}
		set
		{
			_gkQuestionType = value;
		}
	}
	
	public System.String GKQuestion
	{
		get
		{
			return _gkQuestion;
		}
		set
		{
			_gkQuestion = value;
		}
	}
	
	public System.String GKAnswer
	{
		get
		{
			return _gkAnswer;
		}
		set
		{
			_gkAnswer = value;
		}
	}
	
	public System.String GKOption1
	{
		get
		{
			return _gkOption1;
		}
		set
		{
			_gkOption1 = value;
		}
	}
	
	public System.String GKOption2
	{
		get
		{
			return _gkOption2;
		}
		set
		{
			_gkOption2 = value;
		}
	}
	
	public System.String GKOption3
	{
		get
		{
			return _gkOption3;
		}
		set
		{
			_gkOption3 = value;
		}
	}
	
	public System.String GKOption4
	{
		get
		{
			return _gkOption4;
		}
		set
		{
			_gkOption4 = value;
		}
	}
	
	public System.String GKOption5
	{
		get
		{
			return _gkOption5;
		}
		set
		{
			_gkOption5 = value;
		}
	}
	
	public System.String GKQuestionFor
	{
		get
		{
			return _gkQuestionFor;
		}
		set
		{
			_gkQuestionFor = value;
		}
	}
	
	public System.Int64? GKAddedById
	{
		get
		{
			return _gkAddedById;
		}
		set
		{
			_gkAddedById = value;
		}
	}
	
	public System.DateTime? GKTestDate
	{
		get
		{
			return _gkTestDate;
		}
		set
		{
			_gkTestDate = value;
		}
	}
	
	public System.DateTime? GKDate
	{
		get
		{
			return _gkDate;
		}
		set
		{
			_gkDate = value;
		}
	}
	
	public System.Int32? GKStatus
	{
		get
		{
			return _gkStatus;
		}
		set
		{
			_gkStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("GK_KnowledgeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_QuestionType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Question", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Answer", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Option1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Option2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Option3", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Option4", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Option5", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_QuestionFor", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_TestDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("GK_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (GKKnowledgeId == null)
		dr["GK_KnowledgeId"] = DBNull.Value;
		else
		dr["GK_KnowledgeId"] = GKKnowledgeId;
		
		if (GKFacultyId == null)
		dr["GK_FacultyId"] = DBNull.Value;
		else
		dr["GK_FacultyId"] = GKFacultyId;
		
		if (GKStudentId == null)
		dr["GK_StudentId"] = DBNull.Value;
		else
		dr["GK_StudentId"] = GKStudentId;
		
		if (GKSchoolId == null)
		dr["GK_SchoolId"] = DBNull.Value;
		else
		dr["GK_SchoolId"] = GKSchoolId;
		
		if (GKSchoolSubId == null)
		dr["GK_SchoolSubId"] = DBNull.Value;
		else
		dr["GK_SchoolSubId"] = GKSchoolSubId;
		
		if (GKQuestionType == null)
		dr["GK_QuestionType"] = DBNull.Value;
		else
		dr["GK_QuestionType"] = GKQuestionType;
		
		if (GKQuestion == null)
		dr["GK_Question"] = DBNull.Value;
		else
		dr["GK_Question"] = GKQuestion;
		
		if (GKAnswer == null)
		dr["GK_Answer"] = DBNull.Value;
		else
		dr["GK_Answer"] = GKAnswer;
		
		if (GKOption1 == null)
		dr["GK_Option1"] = DBNull.Value;
		else
		dr["GK_Option1"] = GKOption1;
		
		if (GKOption2 == null)
		dr["GK_Option2"] = DBNull.Value;
		else
		dr["GK_Option2"] = GKOption2;
		
		if (GKOption3 == null)
		dr["GK_Option3"] = DBNull.Value;
		else
		dr["GK_Option3"] = GKOption3;
		
		if (GKOption4 == null)
		dr["GK_Option4"] = DBNull.Value;
		else
		dr["GK_Option4"] = GKOption4;
		
		if (GKOption5 == null)
		dr["GK_Option5"] = DBNull.Value;
		else
		dr["GK_Option5"] = GKOption5;
		
		if (GKQuestionFor == null)
		dr["GK_QuestionFor"] = DBNull.Value;
		else
		dr["GK_QuestionFor"] = GKQuestionFor;
		
		if (GKAddedById == null)
		dr["GK_AddedById"] = DBNull.Value;
		else
		dr["GK_AddedById"] = GKAddedById;
		
		if (GKTestDate == null)
		dr["GK_TestDate"] = DBNull.Value;
		else
		dr["GK_TestDate"] = GKTestDate;
		
		if (GKDate == null)
		dr["GK_Date"] = DBNull.Value;
		else
		dr["GK_Date"] = GKDate;
		
		if (GKStatus == null)
		dr["GK_Status"] = DBNull.Value;
		else
		dr["GK_Status"] = GKStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		GKKnowledgeId = dr["GK_KnowledgeId"] != DBNull.Value ? Convert.ToInt64(dr["GK_KnowledgeId"]) : GKKnowledgeId = null;
		GKFacultyId = dr["GK_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["GK_FacultyId"]) : GKFacultyId = null;
		GKStudentId = dr["GK_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["GK_StudentId"]) : GKStudentId = null;
		GKSchoolId = dr["GK_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["GK_SchoolId"]) : GKSchoolId = null;
		GKSchoolSubId = dr["GK_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["GK_SchoolSubId"]) : GKSchoolSubId = null;
		GKQuestionType = dr["GK_QuestionType"] != DBNull.Value ? Convert.ToString(dr["GK_QuestionType"]) : GKQuestionType = null;
		GKQuestion = dr["GK_Question"] != DBNull.Value ? Convert.ToString(dr["GK_Question"]) : GKQuestion = null;
		GKAnswer = dr["GK_Answer"] != DBNull.Value ? Convert.ToString(dr["GK_Answer"]) : GKAnswer = null;
		GKOption1 = dr["GK_Option1"] != DBNull.Value ? Convert.ToString(dr["GK_Option1"]) : GKOption1 = null;
		GKOption2 = dr["GK_Option2"] != DBNull.Value ? Convert.ToString(dr["GK_Option2"]) : GKOption2 = null;
		GKOption3 = dr["GK_Option3"] != DBNull.Value ? Convert.ToString(dr["GK_Option3"]) : GKOption3 = null;
		GKOption4 = dr["GK_Option4"] != DBNull.Value ? Convert.ToString(dr["GK_Option4"]) : GKOption4 = null;
		GKOption5 = dr["GK_Option5"] != DBNull.Value ? Convert.ToString(dr["GK_Option5"]) : GKOption5 = null;
		GKQuestionFor = dr["GK_QuestionFor"] != DBNull.Value ? Convert.ToString(dr["GK_QuestionFor"]) : GKQuestionFor = null;
		GKAddedById = dr["GK_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["GK_AddedById"]) : GKAddedById = null;
		GKTestDate = dr["GK_TestDate"] != DBNull.Value ? Convert.ToDateTime(dr["GK_TestDate"]) : GKTestDate = null;
		GKDate = dr["GK_Date"] != DBNull.Value ? Convert.ToDateTime(dr["GK_Date"]) : GKDate = null;
		GKStatus = dr["GK_Status"] != DBNull.Value ? Convert.ToInt32(dr["GK_Status"]) : GKStatus = null;
	}
	
	public static TMSGeneralKnowledgeDetails[] MapFrom(DataSet ds)
	{
		List<TMSGeneralKnowledgeDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSGeneralKnowledgeDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_GeneralKnowledgeDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_GeneralKnowledgeDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSGeneralKnowledgeDetails instance = new TMSGeneralKnowledgeDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGeneralKnowledgeDetails Get(System.Int64 gkKnowledgeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSGeneralKnowledgeDetails instance;
		
		
		instance = new TMSGeneralKnowledgeDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gkKnowledgeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSGeneralKnowledgeDetails ID:" + gkKnowledgeId.ToString()+ " from Database.");
            return null;
            // Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkOption1, gkOption2, gkOption3, gkOption4, gkOption5, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus);
		
		if (transaction == null)
		this.GKKnowledgeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.GKKnowledgeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus)
	{
		Insert(gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkOption1, gkOption2, gkOption3, gkOption4, gkOption5, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus, null);
	}
	/// <summary>
	/// Insert current TMSGeneralKnowledgeDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(GKFacultyId, GKStudentId, GKSchoolId, GKSchoolSubId, GKQuestionType, GKQuestion, GKAnswer, GKOption1, GKOption2, GKOption3, GKOption4, GKOption5, GKQuestionFor, GKAddedById, GKTestDate, GKDate, GKStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSGeneralKnowledgeDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? gkKnowledgeId, System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gkKnowledgeId"].Value = gkKnowledgeId;
		dbCommand.Parameters["@gkFacultyId"].Value = gkFacultyId;
		dbCommand.Parameters["@gkStudentId"].Value = gkStudentId;
		dbCommand.Parameters["@gkSchoolId"].Value = gkSchoolId;
		dbCommand.Parameters["@gkSchoolSubId"].Value = gkSchoolSubId;
		dbCommand.Parameters["@gkQuestionType"].Value = gkQuestionType;
		dbCommand.Parameters["@gkQuestion"].Value = gkQuestion;
		dbCommand.Parameters["@gkAnswer"].Value = gkAnswer;
		dbCommand.Parameters["@gkOption1"].Value = gkOption1;
		dbCommand.Parameters["@gkOption2"].Value = gkOption2;
		dbCommand.Parameters["@gkOption3"].Value = gkOption3;
		dbCommand.Parameters["@gkOption4"].Value = gkOption4;
		dbCommand.Parameters["@gkOption5"].Value = gkOption5;
		dbCommand.Parameters["@gkQuestionFor"].Value = gkQuestionFor;
		dbCommand.Parameters["@gkAddedById"].Value = gkAddedById;
		dbCommand.Parameters["@gkTestDate"].Value = gkTestDate;
		dbCommand.Parameters["@gkDate"].Value = gkDate;
		dbCommand.Parameters["@gkStatus"].Value = gkStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? gkKnowledgeId, System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus)
	{
		Update(gkKnowledgeId, gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkOption1, gkOption2, gkOption3, gkOption4, gkOption5, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus, null);
	}
	
	public static void Update(TMSGeneralKnowledgeDetails tMSGeneralKnowledgeDetails)
	{
		tMSGeneralKnowledgeDetails.Update();
	}
	
	public static void Update(TMSGeneralKnowledgeDetails tMSGeneralKnowledgeDetails, DbTransaction transaction)
	{
		tMSGeneralKnowledgeDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gkKnowledgeId"].SourceColumn = "GK_KnowledgeId";
		dbCommand.Parameters["@gkFacultyId"].SourceColumn = "GK_FacultyId";
		dbCommand.Parameters["@gkStudentId"].SourceColumn = "GK_StudentId";
		dbCommand.Parameters["@gkSchoolId"].SourceColumn = "GK_SchoolId";
		dbCommand.Parameters["@gkSchoolSubId"].SourceColumn = "GK_SchoolSubId";
		dbCommand.Parameters["@gkQuestionType"].SourceColumn = "GK_QuestionType";
		dbCommand.Parameters["@gkQuestion"].SourceColumn = "GK_Question";
		dbCommand.Parameters["@gkAnswer"].SourceColumn = "GK_Answer";
		dbCommand.Parameters["@gkOption1"].SourceColumn = "GK_Option1";
		dbCommand.Parameters["@gkOption2"].SourceColumn = "GK_Option2";
		dbCommand.Parameters["@gkOption3"].SourceColumn = "GK_Option3";
		dbCommand.Parameters["@gkOption4"].SourceColumn = "GK_Option4";
		dbCommand.Parameters["@gkOption5"].SourceColumn = "GK_Option5";
		dbCommand.Parameters["@gkQuestionFor"].SourceColumn = "GK_QuestionFor";
		dbCommand.Parameters["@gkAddedById"].SourceColumn = "GK_AddedById";
		dbCommand.Parameters["@gkTestDate"].SourceColumn = "GK_TestDate";
		dbCommand.Parameters["@gkDate"].SourceColumn = "GK_Date";
		dbCommand.Parameters["@gkStatus"].SourceColumn = "GK_Status";
		
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
	public static void Delete(System.Int64? gkKnowledgeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gkKnowledgeId);
		
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
	public static void Delete(System.Int64? gkKnowledgeId)
	{
		Delete(
		gkKnowledgeId);
	}
	
	/// <summary>
	/// Delete current TMSGeneralKnowledgeDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, GKKnowledgeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.GKKnowledgeId = null;
	}
	
	/// <summary>
	/// Delete current TMSGeneralKnowledgeDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGeneralKnowledgeDetails[] Search(System.Int64? gkKnowledgeId, System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gkKnowledgeId, gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkOption1, gkOption2, gkOption3, gkOption4, gkOption5, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSGeneralKnowledgeDetails.MapFrom(ds);
	}
	
	
	public static TMSGeneralKnowledgeDetails[] Search(TMSGeneralKnowledgeDetails searchObject)
	{
		return Search ( searchObject.GKKnowledgeId, searchObject.GKFacultyId, searchObject.GKStudentId, searchObject.GKSchoolId, searchObject.GKSchoolSubId, searchObject.GKQuestionType, searchObject.GKQuestion, searchObject.GKAnswer, searchObject.GKOption1, searchObject.GKOption2, searchObject.GKOption3, searchObject.GKOption4, searchObject.GKOption5, searchObject.GKQuestionFor, searchObject.GKAddedById, searchObject.GKTestDate, searchObject.GKDate, searchObject.GKStatus);
	}
	
	/// <summary>
	/// Returns all TMSGeneralKnowledgeDetails objects.
	/// </summary>
	/// <returns>List of all TMSGeneralKnowledgeDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSGeneralKnowledgeDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

