/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/26/2012 1:06:39 PM                                    */
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
public partial class TMSFunStuffDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FunStuffDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fsdFunStuffId;
	private System.Int64? _fsdFacultyId;
	private System.Int64? _fsdStudentId;
	private System.Int64? _fsdSchoolID;
	private System.Int64? _fsdSchoolSubId;
	private System.String _fsdFunStuffType;
	private System.String _fsdFunStuffSubType;
	private System.String _fsdLanguage;
	private System.String _fsdQuestion;
	private System.String _fsdAnswer;
	private System.String _fsdTitle;
	private System.String _fsdDescription;
	private System.String _fsdDescription1;
	private System.String _fsdImage;
	private System.String _fsdAuthorName;
	private System.Int64? _fsdAddedbyId;
	private System.String _fsdExtra;
	private System.String _fsdPuzzleCategory;
	private System.String _fsdPuzzlePlayersType;
	private System.String _fsdGameLink;
	private System.String _fsdVideoUploadName;
	private System.DateTime? _fsdDate;
	private System.Int32? _fsdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FSDFunStuffId
	{
		get
		{
			return _fsdFunStuffId;
		}
		set
		{
			_fsdFunStuffId = value;
		}
	}
	
	public System.Int64? FSDFacultyId
	{
		get
		{
			return _fsdFacultyId;
		}
		set
		{
			_fsdFacultyId = value;
		}
	}
	
	public System.Int64? FSDStudentId
	{
		get
		{
			return _fsdStudentId;
		}
		set
		{
			_fsdStudentId = value;
		}
	}
	
	public System.Int64? FSDSchoolID
	{
		get
		{
			return _fsdSchoolID;
		}
		set
		{
			_fsdSchoolID = value;
		}
	}
	
	public System.Int64? FSDSchoolSubId
	{
		get
		{
			return _fsdSchoolSubId;
		}
		set
		{
			_fsdSchoolSubId = value;
		}
	}
	
	public System.String FSDFunStuffType
	{
		get
		{
			return _fsdFunStuffType;
		}
		set
		{
			_fsdFunStuffType = value;
		}
	}
	
	public System.String FSDFunStuffSubType
	{
		get
		{
			return _fsdFunStuffSubType;
		}
		set
		{
			_fsdFunStuffSubType = value;
		}
	}
	
	public System.String FSDLanguage
	{
		get
		{
			return _fsdLanguage;
		}
		set
		{
			_fsdLanguage = value;
		}
	}
	
	public System.String FSDQuestion
	{
		get
		{
			return _fsdQuestion;
		}
		set
		{
			_fsdQuestion = value;
		}
	}
	
	public System.String FSDAnswer
	{
		get
		{
			return _fsdAnswer;
		}
		set
		{
			_fsdAnswer = value;
		}
	}
	
	public System.String FSDTitle
	{
		get
		{
			return _fsdTitle;
		}
		set
		{
			_fsdTitle = value;
		}
	}
	
	public System.String FSDDescription
	{
		get
		{
			return _fsdDescription;
		}
		set
		{
			_fsdDescription = value;
		}
	}
	
	public System.String FSDDescription1
	{
		get
		{
			return _fsdDescription1;
		}
		set
		{
			_fsdDescription1 = value;
		}
	}
	
	public System.String FSDImage
	{
		get
		{
			return _fsdImage;
		}
		set
		{
			_fsdImage = value;
		}
	}
	
	public System.String FSDAuthorName
	{
		get
		{
			return _fsdAuthorName;
		}
		set
		{
			_fsdAuthorName = value;
		}
	}
	
	public System.Int64? FSDAddedbyId
	{
		get
		{
			return _fsdAddedbyId;
		}
		set
		{
			_fsdAddedbyId = value;
		}
	}
	
	public System.String FSDExtra
	{
		get
		{
			return _fsdExtra;
		}
		set
		{
			_fsdExtra = value;
		}
	}
	
	public System.String FSDPuzzleCategory
	{
		get
		{
			return _fsdPuzzleCategory;
		}
		set
		{
			_fsdPuzzleCategory = value;
		}
	}
	
	public System.String FSDPuzzlePlayersType
	{
		get
		{
			return _fsdPuzzlePlayersType;
		}
		set
		{
			_fsdPuzzlePlayersType = value;
		}
	}
	
	public System.String FSDGameLink
	{
		get
		{
			return _fsdGameLink;
		}
		set
		{
			_fsdGameLink = value;
		}
	}
	
	public System.String FSDVideoUploadName
	{
		get
		{
			return _fsdVideoUploadName;
		}
		set
		{
			_fsdVideoUploadName = value;
		}
	}
	
	public System.DateTime? FSDDate
	{
		get
		{
			return _fsdDate;
		}
		set
		{
			_fsdDate = value;
		}
	}
	
	public System.Int32? FSDStatus
	{
		get
		{
			return _fsdStatus;
		}
		set
		{
			_fsdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FSD_FunStuffId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_SchoolID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_FunStuffType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_FunStuffSubType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Language", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Question", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Answer", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_AuthorName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_AddedbyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_PuzzleCategory", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_PuzzlePlayersType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_GameLink", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_VideoUploadName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FSD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FSDFunStuffId == null)
		dr["FSD_FunStuffId"] = DBNull.Value;
		else
		dr["FSD_FunStuffId"] = FSDFunStuffId;
		
		if (FSDFacultyId == null)
		dr["FSD_FacultyId"] = DBNull.Value;
		else
		dr["FSD_FacultyId"] = FSDFacultyId;
		
		if (FSDStudentId == null)
		dr["FSD_StudentId"] = DBNull.Value;
		else
		dr["FSD_StudentId"] = FSDStudentId;
		
		if (FSDSchoolID == null)
		dr["FSD_SchoolID"] = DBNull.Value;
		else
		dr["FSD_SchoolID"] = FSDSchoolID;
		
		if (FSDSchoolSubId == null)
		dr["FSD_SchoolSubId"] = DBNull.Value;
		else
		dr["FSD_SchoolSubId"] = FSDSchoolSubId;
		
		if (FSDFunStuffType == null)
		dr["FSD_FunStuffType"] = DBNull.Value;
		else
		dr["FSD_FunStuffType"] = FSDFunStuffType;
		
		if (FSDFunStuffSubType == null)
		dr["FSD_FunStuffSubType"] = DBNull.Value;
		else
		dr["FSD_FunStuffSubType"] = FSDFunStuffSubType;
		
		if (FSDLanguage == null)
		dr["FSD_Language"] = DBNull.Value;
		else
		dr["FSD_Language"] = FSDLanguage;
		
		if (FSDQuestion == null)
		dr["FSD_Question"] = DBNull.Value;
		else
		dr["FSD_Question"] = FSDQuestion;
		
		if (FSDAnswer == null)
		dr["FSD_Answer"] = DBNull.Value;
		else
		dr["FSD_Answer"] = FSDAnswer;
		
		if (FSDTitle == null)
		dr["FSD_Title"] = DBNull.Value;
		else
		dr["FSD_Title"] = FSDTitle;
		
		if (FSDDescription == null)
		dr["FSD_Description"] = DBNull.Value;
		else
		dr["FSD_Description"] = FSDDescription;
		
		if (FSDDescription1 == null)
		dr["FSD_Description1"] = DBNull.Value;
		else
		dr["FSD_Description1"] = FSDDescription1;
		
		if (FSDImage == null)
		dr["FSD_Image"] = DBNull.Value;
		else
		dr["FSD_Image"] = FSDImage;
		
		if (FSDAuthorName == null)
		dr["FSD_AuthorName"] = DBNull.Value;
		else
		dr["FSD_AuthorName"] = FSDAuthorName;
		
		if (FSDAddedbyId == null)
		dr["FSD_AddedbyId"] = DBNull.Value;
		else
		dr["FSD_AddedbyId"] = FSDAddedbyId;
		
		if (FSDExtra == null)
		dr["FSD_Extra"] = DBNull.Value;
		else
		dr["FSD_Extra"] = FSDExtra;
		
		if (FSDPuzzleCategory == null)
		dr["FSD_PuzzleCategory"] = DBNull.Value;
		else
		dr["FSD_PuzzleCategory"] = FSDPuzzleCategory;
		
		if (FSDPuzzlePlayersType == null)
		dr["FSD_PuzzlePlayersType"] = DBNull.Value;
		else
		dr["FSD_PuzzlePlayersType"] = FSDPuzzlePlayersType;
		
		if (FSDGameLink == null)
		dr["FSD_GameLink"] = DBNull.Value;
		else
		dr["FSD_GameLink"] = FSDGameLink;
		
		if (FSDVideoUploadName == null)
		dr["FSD_VideoUploadName"] = DBNull.Value;
		else
		dr["FSD_VideoUploadName"] = FSDVideoUploadName;
		
		if (FSDDate == null)
		dr["FSD_Date"] = DBNull.Value;
		else
		dr["FSD_Date"] = FSDDate;
		
		if (FSDStatus == null)
		dr["FSD_Status"] = DBNull.Value;
		else
		dr["FSD_Status"] = FSDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FSDFunStuffId = dr["FSD_FunStuffId"] != DBNull.Value ? Convert.ToInt64(dr["FSD_FunStuffId"]) : FSDFunStuffId = null;
		FSDFacultyId = dr["FSD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["FSD_FacultyId"]) : FSDFacultyId = null;
		FSDStudentId = dr["FSD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["FSD_StudentId"]) : FSDStudentId = null;
		FSDSchoolID = dr["FSD_SchoolID"] != DBNull.Value ? Convert.ToInt64(dr["FSD_SchoolID"]) : FSDSchoolID = null;
		FSDSchoolSubId = dr["FSD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["FSD_SchoolSubId"]) : FSDSchoolSubId = null;
		FSDFunStuffType = dr["FSD_FunStuffType"] != DBNull.Value ? Convert.ToString(dr["FSD_FunStuffType"]) : FSDFunStuffType = null;
		FSDFunStuffSubType = dr["FSD_FunStuffSubType"] != DBNull.Value ? Convert.ToString(dr["FSD_FunStuffSubType"]) : FSDFunStuffSubType = null;
		FSDLanguage = dr["FSD_Language"] != DBNull.Value ? Convert.ToString(dr["FSD_Language"]) : FSDLanguage = null;
		FSDQuestion = dr["FSD_Question"] != DBNull.Value ? Convert.ToString(dr["FSD_Question"]) : FSDQuestion = null;
		FSDAnswer = dr["FSD_Answer"] != DBNull.Value ? Convert.ToString(dr["FSD_Answer"]) : FSDAnswer = null;
		FSDTitle = dr["FSD_Title"] != DBNull.Value ? Convert.ToString(dr["FSD_Title"]) : FSDTitle = null;
		FSDDescription = dr["FSD_Description"] != DBNull.Value ? Convert.ToString(dr["FSD_Description"]) : FSDDescription = null;
		FSDDescription1 = dr["FSD_Description1"] != DBNull.Value ? Convert.ToString(dr["FSD_Description1"]) : FSDDescription1 = null;
		FSDImage = dr["FSD_Image"] != DBNull.Value ? Convert.ToString(dr["FSD_Image"]) : FSDImage = null;
		FSDAuthorName = dr["FSD_AuthorName"] != DBNull.Value ? Convert.ToString(dr["FSD_AuthorName"]) : FSDAuthorName = null;
		FSDAddedbyId = dr["FSD_AddedbyId"] != DBNull.Value ? Convert.ToInt64(dr["FSD_AddedbyId"]) : FSDAddedbyId = null;
		FSDExtra = dr["FSD_Extra"] != DBNull.Value ? Convert.ToString(dr["FSD_Extra"]) : FSDExtra = null;
		FSDPuzzleCategory = dr["FSD_PuzzleCategory"] != DBNull.Value ? Convert.ToString(dr["FSD_PuzzleCategory"]) : FSDPuzzleCategory = null;
		FSDPuzzlePlayersType = dr["FSD_PuzzlePlayersType"] != DBNull.Value ? Convert.ToString(dr["FSD_PuzzlePlayersType"]) : FSDPuzzlePlayersType = null;
		FSDGameLink = dr["FSD_GameLink"] != DBNull.Value ? Convert.ToString(dr["FSD_GameLink"]) : FSDGameLink = null;
		FSDVideoUploadName = dr["FSD_VideoUploadName"] != DBNull.Value ? Convert.ToString(dr["FSD_VideoUploadName"]) : FSDVideoUploadName = null;
		FSDDate = dr["FSD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FSD_Date"]) : FSDDate = null;
		FSDStatus = dr["FSD_Status"] != DBNull.Value ? Convert.ToInt32(dr["FSD_Status"]) : FSDStatus = null;
	}
	
	public static TMSFunStuffDetails[] MapFrom(DataSet ds)
	{
		List<TMSFunStuffDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFunStuffDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FunStuffDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FunStuffDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFunStuffDetails instance = new TMSFunStuffDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffDetails Get(System.Int64 fsdFunStuffId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFunStuffDetails instance;
		
		
		instance = new TMSFunStuffDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFunStuffId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFunStuffDetails ID:" + fsdFunStuffId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus);
		
		if (transaction == null)
		this.FSDFunStuffId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FSDFunStuffId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus)
	{
		Insert(fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus, null);
	}
	/// <summary>
	/// Insert current TMSFunStuffDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FSDFacultyId, FSDStudentId, FSDSchoolID, FSDSchoolSubId, FSDFunStuffType, FSDFunStuffSubType, FSDLanguage, FSDQuestion, FSDAnswer, FSDTitle, FSDDescription, FSDDescription1, FSDImage, FSDAuthorName, FSDAddedbyId, FSDExtra, FSDPuzzleCategory, FSDPuzzlePlayersType, FSDGameLink, FSDVideoUploadName, FSDDate, FSDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFunStuffDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fsdFunStuffId, System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsdFunStuffId"].Value = fsdFunStuffId;
		dbCommand.Parameters["@fsdFacultyId"].Value = fsdFacultyId;
		dbCommand.Parameters["@fsdStudentId"].Value = fsdStudentId;
		dbCommand.Parameters["@fsdSchoolID"].Value = fsdSchoolID;
		dbCommand.Parameters["@fsdSchoolSubId"].Value = fsdSchoolSubId;
		dbCommand.Parameters["@fsdFunStuffType"].Value = fsdFunStuffType;
		dbCommand.Parameters["@fsdFunStuffSubType"].Value = fsdFunStuffSubType;
		dbCommand.Parameters["@fsdLanguage"].Value = fsdLanguage;
		dbCommand.Parameters["@fsdQuestion"].Value = fsdQuestion;
		dbCommand.Parameters["@fsdAnswer"].Value = fsdAnswer;
		dbCommand.Parameters["@fsdTitle"].Value = fsdTitle;
		dbCommand.Parameters["@fsdDescription"].Value = fsdDescription;
		dbCommand.Parameters["@fsdDescription1"].Value = fsdDescription1;
		dbCommand.Parameters["@fsdImage"].Value = fsdImage;
		dbCommand.Parameters["@fsdAuthorName"].Value = fsdAuthorName;
		dbCommand.Parameters["@fsdAddedbyId"].Value = fsdAddedbyId;
		dbCommand.Parameters["@fsdExtra"].Value = fsdExtra;
		dbCommand.Parameters["@fsdPuzzleCategory"].Value = fsdPuzzleCategory;
		dbCommand.Parameters["@fsdPuzzlePlayersType"].Value = fsdPuzzlePlayersType;
		dbCommand.Parameters["@fsdGameLink"].Value = fsdGameLink;
		dbCommand.Parameters["@fsdVideoUploadName"].Value = fsdVideoUploadName;
		dbCommand.Parameters["@fsdDate"].Value = fsdDate;
		dbCommand.Parameters["@fsdStatus"].Value = fsdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fsdFunStuffId, System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus)
	{
		Update(fsdFunStuffId, fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus, null);
	}
	
	public static void Update(TMSFunStuffDetails tMSFunStuffDetails)
	{
		tMSFunStuffDetails.Update();
	}
	
	public static void Update(TMSFunStuffDetails tMSFunStuffDetails, DbTransaction transaction)
	{
		tMSFunStuffDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFunStuffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsdFunStuffId"].SourceColumn = "FSD_FunStuffId";
		dbCommand.Parameters["@fsdFacultyId"].SourceColumn = "FSD_FacultyId";
		dbCommand.Parameters["@fsdStudentId"].SourceColumn = "FSD_StudentId";
		dbCommand.Parameters["@fsdSchoolID"].SourceColumn = "FSD_SchoolID";
		dbCommand.Parameters["@fsdSchoolSubId"].SourceColumn = "FSD_SchoolSubId";
		dbCommand.Parameters["@fsdFunStuffType"].SourceColumn = "FSD_FunStuffType";
		dbCommand.Parameters["@fsdFunStuffSubType"].SourceColumn = "FSD_FunStuffSubType";
		dbCommand.Parameters["@fsdLanguage"].SourceColumn = "FSD_Language";
		dbCommand.Parameters["@fsdQuestion"].SourceColumn = "FSD_Question";
		dbCommand.Parameters["@fsdAnswer"].SourceColumn = "FSD_Answer";
		dbCommand.Parameters["@fsdTitle"].SourceColumn = "FSD_Title";
		dbCommand.Parameters["@fsdDescription"].SourceColumn = "FSD_Description";
		dbCommand.Parameters["@fsdDescription1"].SourceColumn = "FSD_Description1";
		dbCommand.Parameters["@fsdImage"].SourceColumn = "FSD_Image";
		dbCommand.Parameters["@fsdAuthorName"].SourceColumn = "FSD_AuthorName";
		dbCommand.Parameters["@fsdAddedbyId"].SourceColumn = "FSD_AddedbyId";
		dbCommand.Parameters["@fsdExtra"].SourceColumn = "FSD_Extra";
		dbCommand.Parameters["@fsdPuzzleCategory"].SourceColumn = "FSD_PuzzleCategory";
		dbCommand.Parameters["@fsdPuzzlePlayersType"].SourceColumn = "FSD_PuzzlePlayersType";
		dbCommand.Parameters["@fsdGameLink"].SourceColumn = "FSD_GameLink";
		dbCommand.Parameters["@fsdVideoUploadName"].SourceColumn = "FSD_VideoUploadName";
		dbCommand.Parameters["@fsdDate"].SourceColumn = "FSD_Date";
		dbCommand.Parameters["@fsdStatus"].SourceColumn = "FSD_Status";
		
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
	public static void Delete(System.Int64? fsdFunStuffId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFunStuffId);
		
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
	public static void Delete(System.Int64? fsdFunStuffId)
	{
		Delete(
		fsdFunStuffId);
	}
	
	/// <summary>
	/// Delete current TMSFunStuffDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FSDFunStuffId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FSDFunStuffId = null;
	}
	
	/// <summary>
	/// Delete current TMSFunStuffDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffDetails[] Search(System.Int64? fsdFunStuffId, System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFunStuffId, fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFunStuffDetails.MapFrom(ds);
	}
	
	
	public static TMSFunStuffDetails[] Search(TMSFunStuffDetails searchObject)
	{
		return Search ( searchObject.FSDFunStuffId, searchObject.FSDFacultyId, searchObject.FSDStudentId, searchObject.FSDSchoolID, searchObject.FSDSchoolSubId, searchObject.FSDFunStuffType, searchObject.FSDFunStuffSubType, searchObject.FSDLanguage, searchObject.FSDQuestion, searchObject.FSDAnswer, searchObject.FSDTitle, searchObject.FSDDescription, searchObject.FSDDescription1, searchObject.FSDImage, searchObject.FSDAuthorName, searchObject.FSDAddedbyId, searchObject.FSDExtra, searchObject.FSDPuzzleCategory, searchObject.FSDPuzzlePlayersType, searchObject.FSDGameLink, searchObject.FSDVideoUploadName, searchObject.FSDDate, searchObject.FSDStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffDetails objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFunStuffDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

