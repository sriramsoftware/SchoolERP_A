/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/1/2012 3:36:54 PM                                    */
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
public partial class TMSCoScholasticMarksDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CoScholasticMarksDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _mdMarksDetailsId;
	private System.Int64? _mdSkillTypeId;
	private System.Int64? _mdSkillTitleId;
	private System.Int64? _mdSchoolId;
	private System.Int64? _mdSchoolSubId;
	private System.Int64? _mdStudentLoginId;
	private System.Int64? _mdGradeId;
	private System.Int32? _mdGradePoint;
	private System.String _mdGradeName;
	private System.String _mdObtainMarks;
	private System.String _mdTotalMarks;
	private System.String _mdDescription;
	private System.DateTime? _mdDate;
	private System.Int64? _mdAddedById;
	private System.String _mdAddedByType;
	private System.Int32? _mdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? MDMarksDetailsId
	{
		get
		{
			return _mdMarksDetailsId;
		}
		set
		{
			_mdMarksDetailsId = value;
		}
	}
	
	public System.Int64? MDSkillTypeId
	{
		get
		{
			return _mdSkillTypeId;
		}
		set
		{
			_mdSkillTypeId = value;
		}
	}
	
	public System.Int64? MDSkillTitleId
	{
		get
		{
			return _mdSkillTitleId;
		}
		set
		{
			_mdSkillTitleId = value;
		}
	}
	
	public System.Int64? MDSchoolId
	{
		get
		{
			return _mdSchoolId;
		}
		set
		{
			_mdSchoolId = value;
		}
	}
	
	public System.Int64? MDSchoolSubId
	{
		get
		{
			return _mdSchoolSubId;
		}
		set
		{
			_mdSchoolSubId = value;
		}
	}
	
	public System.Int64? MDStudentLoginId
	{
		get
		{
			return _mdStudentLoginId;
		}
		set
		{
			_mdStudentLoginId = value;
		}
	}
	
	public System.Int64? MDGradeId
	{
		get
		{
			return _mdGradeId;
		}
		set
		{
			_mdGradeId = value;
		}
	}
	
	public System.Int32? MDGradePoint
	{
		get
		{
			return _mdGradePoint;
		}
		set
		{
			_mdGradePoint = value;
		}
	}
	
	public System.String MDGradeName
	{
		get
		{
			return _mdGradeName;
		}
		set
		{
			_mdGradeName = value;
		}
	}
	
	public System.String MDObtainMarks
	{
		get
		{
			return _mdObtainMarks;
		}
		set
		{
			_mdObtainMarks = value;
		}
	}
	
	public System.String MDTotalMarks
	{
		get
		{
			return _mdTotalMarks;
		}
		set
		{
			_mdTotalMarks = value;
		}
	}
	
	public System.String MDDescription
	{
		get
		{
			return _mdDescription;
		}
		set
		{
			_mdDescription = value;
		}
	}
	
	public System.DateTime? MDDate
	{
		get
		{
			return _mdDate;
		}
		set
		{
			_mdDate = value;
		}
	}
	
	public System.Int64? MDAddedById
	{
		get
		{
			return _mdAddedById;
		}
		set
		{
			_mdAddedById = value;
		}
	}
	
	public System.String MDAddedByType
	{
		get
		{
			return _mdAddedByType;
		}
		set
		{
			_mdAddedByType = value;
		}
	}
	
	public System.Int32? MDStatus
	{
		get
		{
			return _mdStatus;
		}
		set
		{
			_mdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("MD_MarksDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SkillTypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SkillTitleId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_GradeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_GradePoint", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_GradeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_ObtainMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_TotalMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (MDMarksDetailsId == null)
		dr["MD_MarksDetailsId"] = DBNull.Value;
		else
		dr["MD_MarksDetailsId"] = MDMarksDetailsId;
		
		if (MDSkillTypeId == null)
		dr["MD_SkillTypeId"] = DBNull.Value;
		else
		dr["MD_SkillTypeId"] = MDSkillTypeId;
		
		if (MDSkillTitleId == null)
		dr["MD_SkillTitleId"] = DBNull.Value;
		else
		dr["MD_SkillTitleId"] = MDSkillTitleId;
		
		if (MDSchoolId == null)
		dr["MD_SchoolId"] = DBNull.Value;
		else
		dr["MD_SchoolId"] = MDSchoolId;
		
		if (MDSchoolSubId == null)
		dr["MD_SchoolSubId"] = DBNull.Value;
		else
		dr["MD_SchoolSubId"] = MDSchoolSubId;
		
		if (MDStudentLoginId == null)
		dr["MD_StudentLoginId"] = DBNull.Value;
		else
		dr["MD_StudentLoginId"] = MDStudentLoginId;
		
		if (MDGradeId == null)
		dr["MD_GradeId"] = DBNull.Value;
		else
		dr["MD_GradeId"] = MDGradeId;
		
		if (MDGradePoint == null)
		dr["MD_GradePoint"] = DBNull.Value;
		else
		dr["MD_GradePoint"] = MDGradePoint;
		
		if (MDGradeName == null)
		dr["MD_GradeName"] = DBNull.Value;
		else
		dr["MD_GradeName"] = MDGradeName;
		
		if (MDObtainMarks == null)
		dr["MD_ObtainMarks"] = DBNull.Value;
		else
		dr["MD_ObtainMarks"] = MDObtainMarks;
		
		if (MDTotalMarks == null)
		dr["MD_TotalMarks"] = DBNull.Value;
		else
		dr["MD_TotalMarks"] = MDTotalMarks;
		
		if (MDDescription == null)
		dr["MD_Description"] = DBNull.Value;
		else
		dr["MD_Description"] = MDDescription;
		
		if (MDDate == null)
		dr["MD_Date"] = DBNull.Value;
		else
		dr["MD_Date"] = MDDate;
		
		if (MDAddedById == null)
		dr["MD_AddedById"] = DBNull.Value;
		else
		dr["MD_AddedById"] = MDAddedById;
		
		if (MDAddedByType == null)
		dr["MD_AddedByType"] = DBNull.Value;
		else
		dr["MD_AddedByType"] = MDAddedByType;
		
		if (MDStatus == null)
		dr["MD_Status"] = DBNull.Value;
		else
		dr["MD_Status"] = MDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		MDMarksDetailsId = dr["MD_MarksDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["MD_MarksDetailsId"]) : MDMarksDetailsId = null;
		MDSkillTypeId = dr["MD_SkillTypeId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SkillTypeId"]) : MDSkillTypeId = null;
		MDSkillTitleId = dr["MD_SkillTitleId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SkillTitleId"]) : MDSkillTitleId = null;
		MDSchoolId = dr["MD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SchoolId"]) : MDSchoolId = null;
		MDSchoolSubId = dr["MD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SchoolSubId"]) : MDSchoolSubId = null;
		MDStudentLoginId = dr["MD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["MD_StudentLoginId"]) : MDStudentLoginId = null;
		MDGradeId = dr["MD_GradeId"] != DBNull.Value ? Convert.ToInt64(dr["MD_GradeId"]) : MDGradeId = null;
		MDGradePoint = dr["MD_GradePoint"] != DBNull.Value ? Convert.ToInt32(dr["MD_GradePoint"]) : MDGradePoint = null;
		MDGradeName = dr["MD_GradeName"] != DBNull.Value ? Convert.ToString(dr["MD_GradeName"]) : MDGradeName = null;
		MDObtainMarks = dr["MD_ObtainMarks"] != DBNull.Value ? Convert.ToString(dr["MD_ObtainMarks"]) : MDObtainMarks = null;
		MDTotalMarks = dr["MD_TotalMarks"] != DBNull.Value ? Convert.ToString(dr["MD_TotalMarks"]) : MDTotalMarks = null;
		MDDescription = dr["MD_Description"] != DBNull.Value ? Convert.ToString(dr["MD_Description"]) : MDDescription = null;
		MDDate = dr["MD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["MD_Date"]) : MDDate = null;
		MDAddedById = dr["MD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["MD_AddedById"]) : MDAddedById = null;
		MDAddedByType = dr["MD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["MD_AddedByType"]) : MDAddedByType = null;
		MDStatus = dr["MD_Status"] != DBNull.Value ? Convert.ToInt32(dr["MD_Status"]) : MDStatus = null;
	}
	
	public static TMSCoScholasticMarksDetails[] MapFrom(DataSet ds)
	{
		List<TMSCoScholasticMarksDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCoScholasticMarksDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CoScholasticMarksDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CoScholasticMarksDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCoScholasticMarksDetails instance = new TMSCoScholasticMarksDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticMarksDetails Get(System.Int64 mdMarksDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCoScholasticMarksDetails instance;
		
		
		instance = new TMSCoScholasticMarksDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCoScholasticMarksDetails ID:" + mdMarksDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdSkillTypeId, mdSkillTitleId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdGradeId, mdGradePoint, mdGradeName, mdObtainMarks, mdTotalMarks, mdDescription, mdDate, mdAddedById, mdAddedByType, mdStatus);
		
		if (transaction == null)
		this.MDMarksDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.MDMarksDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus)
	{
		Insert(mdSkillTypeId, mdSkillTitleId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdGradeId, mdGradePoint, mdGradeName, mdObtainMarks, mdTotalMarks, mdDescription, mdDate, mdAddedById, mdAddedByType, mdStatus, null);
	}
	/// <summary>
	/// Insert current TMSCoScholasticMarksDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(MDSkillTypeId, MDSkillTitleId, MDSchoolId, MDSchoolSubId, MDStudentLoginId, MDGradeId, MDGradePoint, MDGradeName, MDObtainMarks, MDTotalMarks, MDDescription, MDDate, MDAddedById, MDAddedByType, MDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCoScholasticMarksDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? mdMarksDetailsId, System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mdMarksDetailsId"].Value = mdMarksDetailsId;
		dbCommand.Parameters["@mdSkillTypeId"].Value = mdSkillTypeId;
		dbCommand.Parameters["@mdSkillTitleId"].Value = mdSkillTitleId;
		dbCommand.Parameters["@mdSchoolId"].Value = mdSchoolId;
		dbCommand.Parameters["@mdSchoolSubId"].Value = mdSchoolSubId;
		dbCommand.Parameters["@mdStudentLoginId"].Value = mdStudentLoginId;
		dbCommand.Parameters["@mdGradeId"].Value = mdGradeId;
		dbCommand.Parameters["@mdGradePoint"].Value = mdGradePoint;
		dbCommand.Parameters["@mdGradeName"].Value = mdGradeName;
		dbCommand.Parameters["@mdObtainMarks"].Value = mdObtainMarks;
		dbCommand.Parameters["@mdTotalMarks"].Value = mdTotalMarks;
		dbCommand.Parameters["@mdDescription"].Value = mdDescription;
		dbCommand.Parameters["@mdDate"].Value = mdDate;
		dbCommand.Parameters["@mdAddedById"].Value = mdAddedById;
		dbCommand.Parameters["@mdAddedByType"].Value = mdAddedByType;
		dbCommand.Parameters["@mdStatus"].Value = mdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? mdMarksDetailsId, System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus)
	{
		Update(mdMarksDetailsId, mdSkillTypeId, mdSkillTitleId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdGradeId, mdGradePoint, mdGradeName, mdObtainMarks, mdTotalMarks, mdDescription, mdDate, mdAddedById, mdAddedByType, mdStatus, null);
	}
	
	public static void Update(TMSCoScholasticMarksDetails tMSCoScholasticMarksDetails)
	{
		tMSCoScholasticMarksDetails.Update();
	}
	
	public static void Update(TMSCoScholasticMarksDetails tMSCoScholasticMarksDetails, DbTransaction transaction)
	{
		tMSCoScholasticMarksDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mdMarksDetailsId"].SourceColumn = "MD_MarksDetailsId";
		dbCommand.Parameters["@mdSkillTypeId"].SourceColumn = "MD_SkillTypeId";
		dbCommand.Parameters["@mdSkillTitleId"].SourceColumn = "MD_SkillTitleId";
		dbCommand.Parameters["@mdSchoolId"].SourceColumn = "MD_SchoolId";
		dbCommand.Parameters["@mdSchoolSubId"].SourceColumn = "MD_SchoolSubId";
		dbCommand.Parameters["@mdStudentLoginId"].SourceColumn = "MD_StudentLoginId";
		dbCommand.Parameters["@mdGradeId"].SourceColumn = "MD_GradeId";
		dbCommand.Parameters["@mdGradePoint"].SourceColumn = "MD_GradePoint";
		dbCommand.Parameters["@mdGradeName"].SourceColumn = "MD_GradeName";
		dbCommand.Parameters["@mdObtainMarks"].SourceColumn = "MD_ObtainMarks";
		dbCommand.Parameters["@mdTotalMarks"].SourceColumn = "MD_TotalMarks";
		dbCommand.Parameters["@mdDescription"].SourceColumn = "MD_Description";
		dbCommand.Parameters["@mdDate"].SourceColumn = "MD_Date";
		dbCommand.Parameters["@mdAddedById"].SourceColumn = "MD_AddedById";
		dbCommand.Parameters["@mdAddedByType"].SourceColumn = "MD_AddedByType";
		dbCommand.Parameters["@mdStatus"].SourceColumn = "MD_Status";
		
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
	public static void Delete(System.Int64? mdMarksDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId);
		
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
	public static void Delete(System.Int64? mdMarksDetailsId)
	{
		Delete(
		mdMarksDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticMarksDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, MDMarksDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.MDMarksDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticMarksDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticMarksDetails[] Search(System.Int64? mdMarksDetailsId, System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId, mdSkillTypeId, mdSkillTitleId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdGradeId, mdGradePoint, mdGradeName, mdObtainMarks, mdTotalMarks, mdDescription, mdDate, mdAddedById, mdAddedByType, mdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCoScholasticMarksDetails.MapFrom(ds);
	}
	
	
	public static TMSCoScholasticMarksDetails[] Search(TMSCoScholasticMarksDetails searchObject)
	{
		return Search ( searchObject.MDMarksDetailsId, searchObject.MDSkillTypeId, searchObject.MDSkillTitleId, searchObject.MDSchoolId, searchObject.MDSchoolSubId, searchObject.MDStudentLoginId, searchObject.MDGradeId, searchObject.MDGradePoint, searchObject.MDGradeName, searchObject.MDObtainMarks, searchObject.MDTotalMarks, searchObject.MDDescription, searchObject.MDDate, searchObject.MDAddedById, searchObject.MDAddedByType, searchObject.MDStatus);
	}
	
	/// <summary>
	/// Returns all TMSCoScholasticMarksDetails objects.
	/// </summary>
	/// <returns>List of all TMSCoScholasticMarksDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCoScholasticMarksDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

