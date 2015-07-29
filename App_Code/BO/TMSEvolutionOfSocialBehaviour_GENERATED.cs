/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/5/2012 4:33:45 PM                                    */
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
public partial class TMSEvolutionOfSocialBehaviour
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfSocialBehaviour]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _esbBehaviourId;
	private System.Int64? _esbSchoolId;
	private System.Int64? _esbSchoolSubId;
	private System.Int64? _esbStudentLoginId;
	private System.String _esbCommonVoluntarily;
	private System.String _esbMyPears;
	private System.String _esbMyToysWithFriends;
	private System.String _esbNeatAndTidy;
	private System.String _esbReponsibleAndCareful;
	private System.String _esbFollowTeacherInstruction;
	private System.String _esbWorkInTimeFrame;
	private System.String _esbFollowSchoolNorms;
	private System.String _esbLikeComeToSchool;
	private System.String _esbParticipateGroupGameActivities;
	private System.String _esbAddedByType;
	private System.Int64? _esbAddedByLoginId;
	private System.DateTime? _esbDate;
	private System.Int32? _esbStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ESBBehaviourId
	{
		get
		{
			return _esbBehaviourId;
		}
		set
		{
			_esbBehaviourId = value;
		}
	}
	
	public System.Int64? ESBSchoolId
	{
		get
		{
			return _esbSchoolId;
		}
		set
		{
			_esbSchoolId = value;
		}
	}
	
	public System.Int64? ESBSchoolSubId
	{
		get
		{
			return _esbSchoolSubId;
		}
		set
		{
			_esbSchoolSubId = value;
		}
	}
	
	public System.Int64? ESBStudentLoginId
	{
		get
		{
			return _esbStudentLoginId;
		}
		set
		{
			_esbStudentLoginId = value;
		}
	}
	
	public System.String ESBCommonVoluntarily
	{
		get
		{
			return _esbCommonVoluntarily;
		}
		set
		{
			_esbCommonVoluntarily = value;
		}
	}
	
	public System.String ESBMyPears
	{
		get
		{
			return _esbMyPears;
		}
		set
		{
			_esbMyPears = value;
		}
	}
	
	public System.String ESBMyToysWithFriends
	{
		get
		{
			return _esbMyToysWithFriends;
		}
		set
		{
			_esbMyToysWithFriends = value;
		}
	}
	
	public System.String ESBNeatAndTidy
	{
		get
		{
			return _esbNeatAndTidy;
		}
		set
		{
			_esbNeatAndTidy = value;
		}
	}
	
	public System.String ESBReponsibleAndCareful
	{
		get
		{
			return _esbReponsibleAndCareful;
		}
		set
		{
			_esbReponsibleAndCareful = value;
		}
	}
	
	public System.String ESBFollowTeacherInstruction
	{
		get
		{
			return _esbFollowTeacherInstruction;
		}
		set
		{
			_esbFollowTeacherInstruction = value;
		}
	}
	
	public System.String ESBWorkInTimeFrame
	{
		get
		{
			return _esbWorkInTimeFrame;
		}
		set
		{
			_esbWorkInTimeFrame = value;
		}
	}
	
	public System.String ESBFollowSchoolNorms
	{
		get
		{
			return _esbFollowSchoolNorms;
		}
		set
		{
			_esbFollowSchoolNorms = value;
		}
	}
	
	public System.String ESBLikeComeToSchool
	{
		get
		{
			return _esbLikeComeToSchool;
		}
		set
		{
			_esbLikeComeToSchool = value;
		}
	}
	
	public System.String ESBParticipateGroupGameActivities
	{
		get
		{
			return _esbParticipateGroupGameActivities;
		}
		set
		{
			_esbParticipateGroupGameActivities = value;
		}
	}
	
	public System.String ESBAddedByType
	{
		get
		{
			return _esbAddedByType;
		}
		set
		{
			_esbAddedByType = value;
		}
	}
	
	public System.Int64? ESBAddedByLoginId
	{
		get
		{
			return _esbAddedByLoginId;
		}
		set
		{
			_esbAddedByLoginId = value;
		}
	}
	
	public System.DateTime? ESBDate
	{
		get
		{
			return _esbDate;
		}
		set
		{
			_esbDate = value;
		}
	}
	
	public System.Int32? ESBStatus
	{
		get
		{
			return _esbStatus;
		}
		set
		{
			_esbStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ESB_BehaviourId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_CommonVoluntarily", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_MyPears", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_MyToysWithFriends", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_NeatAndTidy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_ReponsibleAndCareful", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_FollowTeacherInstruction", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_WorkInTimeFrame", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_FollowSchoolNorms", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_LikeComeToSchool", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_ParticipateGroupGameActivities", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ESB_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ESBBehaviourId == null)
		dr["ESB_BehaviourId"] = DBNull.Value;
		else
		dr["ESB_BehaviourId"] = ESBBehaviourId;
		
		if (ESBSchoolId == null)
		dr["ESB_SchoolId"] = DBNull.Value;
		else
		dr["ESB_SchoolId"] = ESBSchoolId;
		
		if (ESBSchoolSubId == null)
		dr["ESB_SchoolSubId"] = DBNull.Value;
		else
		dr["ESB_SchoolSubId"] = ESBSchoolSubId;
		
		if (ESBStudentLoginId == null)
		dr["ESB_StudentLoginId"] = DBNull.Value;
		else
		dr["ESB_StudentLoginId"] = ESBStudentLoginId;
		
		if (ESBCommonVoluntarily == null)
		dr["ESB_CommonVoluntarily"] = DBNull.Value;
		else
		dr["ESB_CommonVoluntarily"] = ESBCommonVoluntarily;
		
		if (ESBMyPears == null)
		dr["ESB_MyPears"] = DBNull.Value;
		else
		dr["ESB_MyPears"] = ESBMyPears;
		
		if (ESBMyToysWithFriends == null)
		dr["ESB_MyToysWithFriends"] = DBNull.Value;
		else
		dr["ESB_MyToysWithFriends"] = ESBMyToysWithFriends;
		
		if (ESBNeatAndTidy == null)
		dr["ESB_NeatAndTidy"] = DBNull.Value;
		else
		dr["ESB_NeatAndTidy"] = ESBNeatAndTidy;
		
		if (ESBReponsibleAndCareful == null)
		dr["ESB_ReponsibleAndCareful"] = DBNull.Value;
		else
		dr["ESB_ReponsibleAndCareful"] = ESBReponsibleAndCareful;
		
		if (ESBFollowTeacherInstruction == null)
		dr["ESB_FollowTeacherInstruction"] = DBNull.Value;
		else
		dr["ESB_FollowTeacherInstruction"] = ESBFollowTeacherInstruction;
		
		if (ESBWorkInTimeFrame == null)
		dr["ESB_WorkInTimeFrame"] = DBNull.Value;
		else
		dr["ESB_WorkInTimeFrame"] = ESBWorkInTimeFrame;
		
		if (ESBFollowSchoolNorms == null)
		dr["ESB_FollowSchoolNorms"] = DBNull.Value;
		else
		dr["ESB_FollowSchoolNorms"] = ESBFollowSchoolNorms;
		
		if (ESBLikeComeToSchool == null)
		dr["ESB_LikeComeToSchool"] = DBNull.Value;
		else
		dr["ESB_LikeComeToSchool"] = ESBLikeComeToSchool;
		
		if (ESBParticipateGroupGameActivities == null)
		dr["ESB_ParticipateGroupGameActivities"] = DBNull.Value;
		else
		dr["ESB_ParticipateGroupGameActivities"] = ESBParticipateGroupGameActivities;
		
		if (ESBAddedByType == null)
		dr["ESB_AddedByType"] = DBNull.Value;
		else
		dr["ESB_AddedByType"] = ESBAddedByType;
		
		if (ESBAddedByLoginId == null)
		dr["ESB_AddedByLoginId"] = DBNull.Value;
		else
		dr["ESB_AddedByLoginId"] = ESBAddedByLoginId;
		
		if (ESBDate == null)
		dr["ESB_Date"] = DBNull.Value;
		else
		dr["ESB_Date"] = ESBDate;
		
		if (ESBStatus == null)
		dr["ESB_Status"] = DBNull.Value;
		else
		dr["ESB_Status"] = ESBStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ESBBehaviourId = dr["ESB_BehaviourId"] != DBNull.Value ? Convert.ToInt64(dr["ESB_BehaviourId"]) : ESBBehaviourId = null;
		ESBSchoolId = dr["ESB_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ESB_SchoolId"]) : ESBSchoolId = null;
		ESBSchoolSubId = dr["ESB_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ESB_SchoolSubId"]) : ESBSchoolSubId = null;
		ESBStudentLoginId = dr["ESB_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ESB_StudentLoginId"]) : ESBStudentLoginId = null;
		ESBCommonVoluntarily = dr["ESB_CommonVoluntarily"] != DBNull.Value ? Convert.ToString(dr["ESB_CommonVoluntarily"]) : ESBCommonVoluntarily = null;
		ESBMyPears = dr["ESB_MyPears"] != DBNull.Value ? Convert.ToString(dr["ESB_MyPears"]) : ESBMyPears = null;
		ESBMyToysWithFriends = dr["ESB_MyToysWithFriends"] != DBNull.Value ? Convert.ToString(dr["ESB_MyToysWithFriends"]) : ESBMyToysWithFriends = null;
		ESBNeatAndTidy = dr["ESB_NeatAndTidy"] != DBNull.Value ? Convert.ToString(dr["ESB_NeatAndTidy"]) : ESBNeatAndTidy = null;
		ESBReponsibleAndCareful = dr["ESB_ReponsibleAndCareful"] != DBNull.Value ? Convert.ToString(dr["ESB_ReponsibleAndCareful"]) : ESBReponsibleAndCareful = null;
		ESBFollowTeacherInstruction = dr["ESB_FollowTeacherInstruction"] != DBNull.Value ? Convert.ToString(dr["ESB_FollowTeacherInstruction"]) : ESBFollowTeacherInstruction = null;
		ESBWorkInTimeFrame = dr["ESB_WorkInTimeFrame"] != DBNull.Value ? Convert.ToString(dr["ESB_WorkInTimeFrame"]) : ESBWorkInTimeFrame = null;
		ESBFollowSchoolNorms = dr["ESB_FollowSchoolNorms"] != DBNull.Value ? Convert.ToString(dr["ESB_FollowSchoolNorms"]) : ESBFollowSchoolNorms = null;
		ESBLikeComeToSchool = dr["ESB_LikeComeToSchool"] != DBNull.Value ? Convert.ToString(dr["ESB_LikeComeToSchool"]) : ESBLikeComeToSchool = null;
		ESBParticipateGroupGameActivities = dr["ESB_ParticipateGroupGameActivities"] != DBNull.Value ? Convert.ToString(dr["ESB_ParticipateGroupGameActivities"]) : ESBParticipateGroupGameActivities = null;
		ESBAddedByType = dr["ESB_AddedByType"] != DBNull.Value ? Convert.ToString(dr["ESB_AddedByType"]) : ESBAddedByType = null;
		ESBAddedByLoginId = dr["ESB_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ESB_AddedByLoginId"]) : ESBAddedByLoginId = null;
		ESBDate = dr["ESB_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ESB_Date"]) : ESBDate = null;
		ESBStatus = dr["ESB_Status"] != DBNull.Value ? Convert.ToInt32(dr["ESB_Status"]) : ESBStatus = null;
	}
	
	public static TMSEvolutionOfSocialBehaviour[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfSocialBehaviour> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfSocialBehaviour>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfSocialBehaviour] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfSocialBehaviour] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfSocialBehaviour instance = new TMSEvolutionOfSocialBehaviour();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfSocialBehaviour Get(System.Int64 esbBehaviourId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfSocialBehaviour instance;
		
		
		instance = new TMSEvolutionOfSocialBehaviour();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, esbBehaviourId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfSocialBehaviour ID:" + esbBehaviourId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, esbSchoolId, esbSchoolSubId, esbStudentLoginId, esbCommonVoluntarily, esbMyPears, esbMyToysWithFriends, esbNeatAndTidy, esbReponsibleAndCareful, esbFollowTeacherInstruction, esbWorkInTimeFrame, esbFollowSchoolNorms, esbLikeComeToSchool, esbParticipateGroupGameActivities, esbAddedByType, esbAddedByLoginId, esbDate, esbStatus);
		
		if (transaction == null)
		this.ESBBehaviourId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ESBBehaviourId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus)
	{
		Insert(esbSchoolId, esbSchoolSubId, esbStudentLoginId, esbCommonVoluntarily, esbMyPears, esbMyToysWithFriends, esbNeatAndTidy, esbReponsibleAndCareful, esbFollowTeacherInstruction, esbWorkInTimeFrame, esbFollowSchoolNorms, esbLikeComeToSchool, esbParticipateGroupGameActivities, esbAddedByType, esbAddedByLoginId, esbDate, esbStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfSocialBehaviour to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ESBSchoolId, ESBSchoolSubId, ESBStudentLoginId, ESBCommonVoluntarily, ESBMyPears, ESBMyToysWithFriends, ESBNeatAndTidy, ESBReponsibleAndCareful, ESBFollowTeacherInstruction, ESBWorkInTimeFrame, ESBFollowSchoolNorms, ESBLikeComeToSchool, ESBParticipateGroupGameActivities, ESBAddedByType, ESBAddedByLoginId, ESBDate, ESBStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfSocialBehaviour to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? esbBehaviourId, System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@esbBehaviourId"].Value = esbBehaviourId;
		dbCommand.Parameters["@esbSchoolId"].Value = esbSchoolId;
		dbCommand.Parameters["@esbSchoolSubId"].Value = esbSchoolSubId;
		dbCommand.Parameters["@esbStudentLoginId"].Value = esbStudentLoginId;
		dbCommand.Parameters["@esbCommonVoluntarily"].Value = esbCommonVoluntarily;
		dbCommand.Parameters["@esbMyPears"].Value = esbMyPears;
		dbCommand.Parameters["@esbMyToysWithFriends"].Value = esbMyToysWithFriends;
		dbCommand.Parameters["@esbNeatAndTidy"].Value = esbNeatAndTidy;
		dbCommand.Parameters["@esbReponsibleAndCareful"].Value = esbReponsibleAndCareful;
		dbCommand.Parameters["@esbFollowTeacherInstruction"].Value = esbFollowTeacherInstruction;
		dbCommand.Parameters["@esbWorkInTimeFrame"].Value = esbWorkInTimeFrame;
		dbCommand.Parameters["@esbFollowSchoolNorms"].Value = esbFollowSchoolNorms;
		dbCommand.Parameters["@esbLikeComeToSchool"].Value = esbLikeComeToSchool;
		dbCommand.Parameters["@esbParticipateGroupGameActivities"].Value = esbParticipateGroupGameActivities;
		dbCommand.Parameters["@esbAddedByType"].Value = esbAddedByType;
		dbCommand.Parameters["@esbAddedByLoginId"].Value = esbAddedByLoginId;
		dbCommand.Parameters["@esbDate"].Value = esbDate;
		dbCommand.Parameters["@esbStatus"].Value = esbStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? esbBehaviourId, System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus)
	{
		Update(esbBehaviourId, esbSchoolId, esbSchoolSubId, esbStudentLoginId, esbCommonVoluntarily, esbMyPears, esbMyToysWithFriends, esbNeatAndTidy, esbReponsibleAndCareful, esbFollowTeacherInstruction, esbWorkInTimeFrame, esbFollowSchoolNorms, esbLikeComeToSchool, esbParticipateGroupGameActivities, esbAddedByType, esbAddedByLoginId, esbDate, esbStatus, null);
	}
	
	public static void Update(TMSEvolutionOfSocialBehaviour tMSEvolutionOfSocialBehaviour)
	{
		tMSEvolutionOfSocialBehaviour.Update();
	}
	
	public static void Update(TMSEvolutionOfSocialBehaviour tMSEvolutionOfSocialBehaviour, DbTransaction transaction)
	{
		tMSEvolutionOfSocialBehaviour.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@esbBehaviourId"].SourceColumn = "ESB_BehaviourId";
		dbCommand.Parameters["@esbSchoolId"].SourceColumn = "ESB_SchoolId";
		dbCommand.Parameters["@esbSchoolSubId"].SourceColumn = "ESB_SchoolSubId";
		dbCommand.Parameters["@esbStudentLoginId"].SourceColumn = "ESB_StudentLoginId";
		dbCommand.Parameters["@esbCommonVoluntarily"].SourceColumn = "ESB_CommonVoluntarily";
		dbCommand.Parameters["@esbMyPears"].SourceColumn = "ESB_MyPears";
		dbCommand.Parameters["@esbMyToysWithFriends"].SourceColumn = "ESB_MyToysWithFriends";
		dbCommand.Parameters["@esbNeatAndTidy"].SourceColumn = "ESB_NeatAndTidy";
		dbCommand.Parameters["@esbReponsibleAndCareful"].SourceColumn = "ESB_ReponsibleAndCareful";
		dbCommand.Parameters["@esbFollowTeacherInstruction"].SourceColumn = "ESB_FollowTeacherInstruction";
		dbCommand.Parameters["@esbWorkInTimeFrame"].SourceColumn = "ESB_WorkInTimeFrame";
		dbCommand.Parameters["@esbFollowSchoolNorms"].SourceColumn = "ESB_FollowSchoolNorms";
		dbCommand.Parameters["@esbLikeComeToSchool"].SourceColumn = "ESB_LikeComeToSchool";
		dbCommand.Parameters["@esbParticipateGroupGameActivities"].SourceColumn = "ESB_ParticipateGroupGameActivities";
		dbCommand.Parameters["@esbAddedByType"].SourceColumn = "ESB_AddedByType";
		dbCommand.Parameters["@esbAddedByLoginId"].SourceColumn = "ESB_AddedByLoginId";
		dbCommand.Parameters["@esbDate"].SourceColumn = "ESB_Date";
		dbCommand.Parameters["@esbStatus"].SourceColumn = "ESB_Status";
		
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
	public static void Delete(System.Int64? esbBehaviourId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, esbBehaviourId);
		
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
	public static void Delete(System.Int64? esbBehaviourId)
	{
		Delete(
		esbBehaviourId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfSocialBehaviour from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ESBBehaviourId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ESBBehaviourId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfSocialBehaviour from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfSocialBehaviour[] Search(System.Int64? esbBehaviourId, System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, esbBehaviourId, esbSchoolId, esbSchoolSubId, esbStudentLoginId, esbCommonVoluntarily, esbMyPears, esbMyToysWithFriends, esbNeatAndTidy, esbReponsibleAndCareful, esbFollowTeacherInstruction, esbWorkInTimeFrame, esbFollowSchoolNorms, esbLikeComeToSchool, esbParticipateGroupGameActivities, esbAddedByType, esbAddedByLoginId, esbDate, esbStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfSocialBehaviour.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfSocialBehaviour[] Search(TMSEvolutionOfSocialBehaviour searchObject)
	{
		return Search ( searchObject.ESBBehaviourId, searchObject.ESBSchoolId, searchObject.ESBSchoolSubId, searchObject.ESBStudentLoginId, searchObject.ESBCommonVoluntarily, searchObject.ESBMyPears, searchObject.ESBMyToysWithFriends, searchObject.ESBNeatAndTidy, searchObject.ESBReponsibleAndCareful, searchObject.ESBFollowTeacherInstruction, searchObject.ESBWorkInTimeFrame, searchObject.ESBFollowSchoolNorms, searchObject.ESBLikeComeToSchool, searchObject.ESBParticipateGroupGameActivities, searchObject.ESBAddedByType, searchObject.ESBAddedByLoginId, searchObject.ESBDate, searchObject.ESBStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfSocialBehaviour objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfSocialBehaviour objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfSocialBehaviour[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

