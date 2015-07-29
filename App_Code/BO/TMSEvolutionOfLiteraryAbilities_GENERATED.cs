/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/5/2012 1:27:43 PM                                    */
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
public partial class TMSEvolutionOfLiteraryAbilities
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfLiteraryAbilities]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _elaAbilityId;
	private System.Int64? _elaSchoolId;
	private System.Int64? _elaSchoolSubId;
	private System.Int64? _elaStudentLoginId;
	private System.String _elaAllLetters;
	private System.String _elaNumbers;
	private System.String _elaColours;
	private System.String _elaShape;
	private System.String _elaVegetableFruits;
	private System.String _elaAnimalBirds;
	private System.String _elaMeansOfTransport;
	private System.String _elaCoomonArticleSchoolHome;
	private System.String _elaMyNamePrint;
	private System.String _elaLikeComeToSchool;
	private System.String _elaArticulateWell;
	private System.String _elaRecite;
	private System.String _elaStoryTell;
	private System.String _elaExpressIdeas;
	private System.String _elaDevelopeNewWords;
	private System.String _elaConverseFairlyWell;
	private System.String _elaFormLetters;
	private System.String _elaMakeSimplePattern;
	private System.String _elaAddedByType;
	private System.Int64? _elaAddedByLoginId;
	private System.DateTime? _elaDate;
	private System.Int32? _elaStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ELAAbilityId
	{
		get
		{
			return _elaAbilityId;
		}
		set
		{
			_elaAbilityId = value;
		}
	}
	
	public System.Int64? ELASchoolId
	{
		get
		{
			return _elaSchoolId;
		}
		set
		{
			_elaSchoolId = value;
		}
	}
	
	public System.Int64? ELASchoolSubId
	{
		get
		{
			return _elaSchoolSubId;
		}
		set
		{
			_elaSchoolSubId = value;
		}
	}
	
	public System.Int64? ELAStudentLoginId
	{
		get
		{
			return _elaStudentLoginId;
		}
		set
		{
			_elaStudentLoginId = value;
		}
	}
	
	public System.String ELAAllLetters
	{
		get
		{
			return _elaAllLetters;
		}
		set
		{
			_elaAllLetters = value;
		}
	}
	
	public System.String ELANumbers
	{
		get
		{
			return _elaNumbers;
		}
		set
		{
			_elaNumbers = value;
		}
	}
	
	public System.String ELAColours
	{
		get
		{
			return _elaColours;
		}
		set
		{
			_elaColours = value;
		}
	}
	
	public System.String ELAShape
	{
		get
		{
			return _elaShape;
		}
		set
		{
			_elaShape = value;
		}
	}
	
	public System.String ELAVegetableFruits
	{
		get
		{
			return _elaVegetableFruits;
		}
		set
		{
			_elaVegetableFruits = value;
		}
	}
	
	public System.String ELAAnimalBirds
	{
		get
		{
			return _elaAnimalBirds;
		}
		set
		{
			_elaAnimalBirds = value;
		}
	}
	
	public System.String ELAMeansOfTransport
	{
		get
		{
			return _elaMeansOfTransport;
		}
		set
		{
			_elaMeansOfTransport = value;
		}
	}
	
	public System.String ELACoomonArticleSchoolHome
	{
		get
		{
			return _elaCoomonArticleSchoolHome;
		}
		set
		{
			_elaCoomonArticleSchoolHome = value;
		}
	}
	
	public System.String ELAMyNamePrint
	{
		get
		{
			return _elaMyNamePrint;
		}
		set
		{
			_elaMyNamePrint = value;
		}
	}
	
	public System.String ELALikeComeToSchool
	{
		get
		{
			return _elaLikeComeToSchool;
		}
		set
		{
			_elaLikeComeToSchool = value;
		}
	}
	
	public System.String ELAArticulateWell
	{
		get
		{
			return _elaArticulateWell;
		}
		set
		{
			_elaArticulateWell = value;
		}
	}
	
	public System.String ELARecite
	{
		get
		{
			return _elaRecite;
		}
		set
		{
			_elaRecite = value;
		}
	}
	
	public System.String ELAStoryTell
	{
		get
		{
			return _elaStoryTell;
		}
		set
		{
			_elaStoryTell = value;
		}
	}
	
	public System.String ELAExpressIdeas
	{
		get
		{
			return _elaExpressIdeas;
		}
		set
		{
			_elaExpressIdeas = value;
		}
	}
	
	public System.String ELADevelopeNewWords
	{
		get
		{
			return _elaDevelopeNewWords;
		}
		set
		{
			_elaDevelopeNewWords = value;
		}
	}
	
	public System.String ELAConverseFairlyWell
	{
		get
		{
			return _elaConverseFairlyWell;
		}
		set
		{
			_elaConverseFairlyWell = value;
		}
	}
	
	public System.String ELAFormLetters
	{
		get
		{
			return _elaFormLetters;
		}
		set
		{
			_elaFormLetters = value;
		}
	}
	
	public System.String ELAMakeSimplePattern
	{
		get
		{
			return _elaMakeSimplePattern;
		}
		set
		{
			_elaMakeSimplePattern = value;
		}
	}
	
	public System.String ELAAddedByType
	{
		get
		{
			return _elaAddedByType;
		}
		set
		{
			_elaAddedByType = value;
		}
	}
	
	public System.Int64? ELAAddedByLoginId
	{
		get
		{
			return _elaAddedByLoginId;
		}
		set
		{
			_elaAddedByLoginId = value;
		}
	}
	
	public System.DateTime? ELADate
	{
		get
		{
			return _elaDate;
		}
		set
		{
			_elaDate = value;
		}
	}
	
	public System.Int32? ELAStatus
	{
		get
		{
			return _elaStatus;
		}
		set
		{
			_elaStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ELA_AbilityId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_AllLetters", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Numbers", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Colours", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Shape", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_VegetableFruits", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_AnimalBirds", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_MeansOfTransport", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_CoomonArticleSchoolHome", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_MyNamePrint", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_LikeComeToSchool", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_ArticulateWell", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Recite", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_StoryTell", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_ExpressIdeas", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_DevelopeNewWords", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_ConverseFairlyWell", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_FormLetters", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_MakeSimplePattern", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ELA_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ELAAbilityId == null)
		dr["ELA_AbilityId"] = DBNull.Value;
		else
		dr["ELA_AbilityId"] = ELAAbilityId;
		
		if (ELASchoolId == null)
		dr["ELA_SchoolId"] = DBNull.Value;
		else
		dr["ELA_SchoolId"] = ELASchoolId;
		
		if (ELASchoolSubId == null)
		dr["ELA_SchoolSubId"] = DBNull.Value;
		else
		dr["ELA_SchoolSubId"] = ELASchoolSubId;
		
		if (ELAStudentLoginId == null)
		dr["ELA_StudentLoginId"] = DBNull.Value;
		else
		dr["ELA_StudentLoginId"] = ELAStudentLoginId;
		
		if (ELAAllLetters == null)
		dr["ELA_AllLetters"] = DBNull.Value;
		else
		dr["ELA_AllLetters"] = ELAAllLetters;
		
		if (ELANumbers == null)
		dr["ELA_Numbers"] = DBNull.Value;
		else
		dr["ELA_Numbers"] = ELANumbers;
		
		if (ELAColours == null)
		dr["ELA_Colours"] = DBNull.Value;
		else
		dr["ELA_Colours"] = ELAColours;
		
		if (ELAShape == null)
		dr["ELA_Shape"] = DBNull.Value;
		else
		dr["ELA_Shape"] = ELAShape;
		
		if (ELAVegetableFruits == null)
		dr["ELA_VegetableFruits"] = DBNull.Value;
		else
		dr["ELA_VegetableFruits"] = ELAVegetableFruits;
		
		if (ELAAnimalBirds == null)
		dr["ELA_AnimalBirds"] = DBNull.Value;
		else
		dr["ELA_AnimalBirds"] = ELAAnimalBirds;
		
		if (ELAMeansOfTransport == null)
		dr["ELA_MeansOfTransport"] = DBNull.Value;
		else
		dr["ELA_MeansOfTransport"] = ELAMeansOfTransport;
		
		if (ELACoomonArticleSchoolHome == null)
		dr["ELA_CoomonArticleSchoolHome"] = DBNull.Value;
		else
		dr["ELA_CoomonArticleSchoolHome"] = ELACoomonArticleSchoolHome;
		
		if (ELAMyNamePrint == null)
		dr["ELA_MyNamePrint"] = DBNull.Value;
		else
		dr["ELA_MyNamePrint"] = ELAMyNamePrint;
		
		if (ELALikeComeToSchool == null)
		dr["ELA_LikeComeToSchool"] = DBNull.Value;
		else
		dr["ELA_LikeComeToSchool"] = ELALikeComeToSchool;
		
		if (ELAArticulateWell == null)
		dr["ELA_ArticulateWell"] = DBNull.Value;
		else
		dr["ELA_ArticulateWell"] = ELAArticulateWell;
		
		if (ELARecite == null)
		dr["ELA_Recite"] = DBNull.Value;
		else
		dr["ELA_Recite"] = ELARecite;
		
		if (ELAStoryTell == null)
		dr["ELA_StoryTell"] = DBNull.Value;
		else
		dr["ELA_StoryTell"] = ELAStoryTell;
		
		if (ELAExpressIdeas == null)
		dr["ELA_ExpressIdeas"] = DBNull.Value;
		else
		dr["ELA_ExpressIdeas"] = ELAExpressIdeas;
		
		if (ELADevelopeNewWords == null)
		dr["ELA_DevelopeNewWords"] = DBNull.Value;
		else
		dr["ELA_DevelopeNewWords"] = ELADevelopeNewWords;
		
		if (ELAConverseFairlyWell == null)
		dr["ELA_ConverseFairlyWell"] = DBNull.Value;
		else
		dr["ELA_ConverseFairlyWell"] = ELAConverseFairlyWell;
		
		if (ELAFormLetters == null)
		dr["ELA_FormLetters"] = DBNull.Value;
		else
		dr["ELA_FormLetters"] = ELAFormLetters;
		
		if (ELAMakeSimplePattern == null)
		dr["ELA_MakeSimplePattern"] = DBNull.Value;
		else
		dr["ELA_MakeSimplePattern"] = ELAMakeSimplePattern;
		
		if (ELAAddedByType == null)
		dr["ELA_AddedByType"] = DBNull.Value;
		else
		dr["ELA_AddedByType"] = ELAAddedByType;
		
		if (ELAAddedByLoginId == null)
		dr["ELA_AddedByLoginId"] = DBNull.Value;
		else
		dr["ELA_AddedByLoginId"] = ELAAddedByLoginId;
		
		if (ELADate == null)
		dr["ELA_Date"] = DBNull.Value;
		else
		dr["ELA_Date"] = ELADate;
		
		if (ELAStatus == null)
		dr["ELA_Status"] = DBNull.Value;
		else
		dr["ELA_Status"] = ELAStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ELAAbilityId = dr["ELA_AbilityId"] != DBNull.Value ? Convert.ToInt64(dr["ELA_AbilityId"]) : ELAAbilityId = null;
		ELASchoolId = dr["ELA_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ELA_SchoolId"]) : ELASchoolId = null;
		ELASchoolSubId = dr["ELA_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ELA_SchoolSubId"]) : ELASchoolSubId = null;
		ELAStudentLoginId = dr["ELA_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ELA_StudentLoginId"]) : ELAStudentLoginId = null;
		ELAAllLetters = dr["ELA_AllLetters"] != DBNull.Value ? Convert.ToString(dr["ELA_AllLetters"]) : ELAAllLetters = null;
		ELANumbers = dr["ELA_Numbers"] != DBNull.Value ? Convert.ToString(dr["ELA_Numbers"]) : ELANumbers = null;
		ELAColours = dr["ELA_Colours"] != DBNull.Value ? Convert.ToString(dr["ELA_Colours"]) : ELAColours = null;
		ELAShape = dr["ELA_Shape"] != DBNull.Value ? Convert.ToString(dr["ELA_Shape"]) : ELAShape = null;
		ELAVegetableFruits = dr["ELA_VegetableFruits"] != DBNull.Value ? Convert.ToString(dr["ELA_VegetableFruits"]) : ELAVegetableFruits = null;
		ELAAnimalBirds = dr["ELA_AnimalBirds"] != DBNull.Value ? Convert.ToString(dr["ELA_AnimalBirds"]) : ELAAnimalBirds = null;
		ELAMeansOfTransport = dr["ELA_MeansOfTransport"] != DBNull.Value ? Convert.ToString(dr["ELA_MeansOfTransport"]) : ELAMeansOfTransport = null;
		ELACoomonArticleSchoolHome = dr["ELA_CoomonArticleSchoolHome"] != DBNull.Value ? Convert.ToString(dr["ELA_CoomonArticleSchoolHome"]) : ELACoomonArticleSchoolHome = null;
		ELAMyNamePrint = dr["ELA_MyNamePrint"] != DBNull.Value ? Convert.ToString(dr["ELA_MyNamePrint"]) : ELAMyNamePrint = null;
		ELALikeComeToSchool = dr["ELA_LikeComeToSchool"] != DBNull.Value ? Convert.ToString(dr["ELA_LikeComeToSchool"]) : ELALikeComeToSchool = null;
		ELAArticulateWell = dr["ELA_ArticulateWell"] != DBNull.Value ? Convert.ToString(dr["ELA_ArticulateWell"]) : ELAArticulateWell = null;
		ELARecite = dr["ELA_Recite"] != DBNull.Value ? Convert.ToString(dr["ELA_Recite"]) : ELARecite = null;
		ELAStoryTell = dr["ELA_StoryTell"] != DBNull.Value ? Convert.ToString(dr["ELA_StoryTell"]) : ELAStoryTell = null;
		ELAExpressIdeas = dr["ELA_ExpressIdeas"] != DBNull.Value ? Convert.ToString(dr["ELA_ExpressIdeas"]) : ELAExpressIdeas = null;
		ELADevelopeNewWords = dr["ELA_DevelopeNewWords"] != DBNull.Value ? Convert.ToString(dr["ELA_DevelopeNewWords"]) : ELADevelopeNewWords = null;
		ELAConverseFairlyWell = dr["ELA_ConverseFairlyWell"] != DBNull.Value ? Convert.ToString(dr["ELA_ConverseFairlyWell"]) : ELAConverseFairlyWell = null;
		ELAFormLetters = dr["ELA_FormLetters"] != DBNull.Value ? Convert.ToString(dr["ELA_FormLetters"]) : ELAFormLetters = null;
		ELAMakeSimplePattern = dr["ELA_MakeSimplePattern"] != DBNull.Value ? Convert.ToString(dr["ELA_MakeSimplePattern"]) : ELAMakeSimplePattern = null;
		ELAAddedByType = dr["ELA_AddedByType"] != DBNull.Value ? Convert.ToString(dr["ELA_AddedByType"]) : ELAAddedByType = null;
		ELAAddedByLoginId = dr["ELA_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ELA_AddedByLoginId"]) : ELAAddedByLoginId = null;
		ELADate = dr["ELA_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ELA_Date"]) : ELADate = null;
		ELAStatus = dr["ELA_Status"] != DBNull.Value ? Convert.ToInt32(dr["ELA_Status"]) : ELAStatus = null;
	}
	
	public static TMSEvolutionOfLiteraryAbilities[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfLiteraryAbilities> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfLiteraryAbilities>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfLiteraryAbilities] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfLiteraryAbilities] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfLiteraryAbilities instance = new TMSEvolutionOfLiteraryAbilities();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfLiteraryAbilities Get(System.Int64 elaAbilityId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfLiteraryAbilities instance;
		
		
		instance = new TMSEvolutionOfLiteraryAbilities();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elaAbilityId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfLiteraryAbilities ID:" + elaAbilityId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elaSchoolId, elaSchoolSubId, elaStudentLoginId, elaAllLetters, elaNumbers, elaColours, elaShape, elaVegetableFruits, elaAnimalBirds, elaMeansOfTransport, elaCoomonArticleSchoolHome, elaMyNamePrint, elaLikeComeToSchool, elaArticulateWell, elaRecite, elaStoryTell, elaExpressIdeas, elaDevelopeNewWords, elaConverseFairlyWell, elaFormLetters, elaMakeSimplePattern, elaAddedByType, elaAddedByLoginId, elaDate, elaStatus);
		
		if (transaction == null)
		this.ELAAbilityId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ELAAbilityId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus)
	{
		Insert(elaSchoolId, elaSchoolSubId, elaStudentLoginId, elaAllLetters, elaNumbers, elaColours, elaShape, elaVegetableFruits, elaAnimalBirds, elaMeansOfTransport, elaCoomonArticleSchoolHome, elaMyNamePrint, elaLikeComeToSchool, elaArticulateWell, elaRecite, elaStoryTell, elaExpressIdeas, elaDevelopeNewWords, elaConverseFairlyWell, elaFormLetters, elaMakeSimplePattern, elaAddedByType, elaAddedByLoginId, elaDate, elaStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfLiteraryAbilities to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ELASchoolId, ELASchoolSubId, ELAStudentLoginId, ELAAllLetters, ELANumbers, ELAColours, ELAShape, ELAVegetableFruits, ELAAnimalBirds, ELAMeansOfTransport, ELACoomonArticleSchoolHome, ELAMyNamePrint, ELALikeComeToSchool, ELAArticulateWell, ELARecite, ELAStoryTell, ELAExpressIdeas, ELADevelopeNewWords, ELAConverseFairlyWell, ELAFormLetters, ELAMakeSimplePattern, ELAAddedByType, ELAAddedByLoginId, ELADate, ELAStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfLiteraryAbilities to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? elaAbilityId, System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@elaAbilityId"].Value = elaAbilityId;
		dbCommand.Parameters["@elaSchoolId"].Value = elaSchoolId;
		dbCommand.Parameters["@elaSchoolSubId"].Value = elaSchoolSubId;
		dbCommand.Parameters["@elaStudentLoginId"].Value = elaStudentLoginId;
		dbCommand.Parameters["@elaAllLetters"].Value = elaAllLetters;
		dbCommand.Parameters["@elaNumbers"].Value = elaNumbers;
		dbCommand.Parameters["@elaColours"].Value = elaColours;
		dbCommand.Parameters["@elaShape"].Value = elaShape;
		dbCommand.Parameters["@elaVegetableFruits"].Value = elaVegetableFruits;
		dbCommand.Parameters["@elaAnimalBirds"].Value = elaAnimalBirds;
		dbCommand.Parameters["@elaMeansOfTransport"].Value = elaMeansOfTransport;
		dbCommand.Parameters["@elaCoomonArticleSchoolHome"].Value = elaCoomonArticleSchoolHome;
		dbCommand.Parameters["@elaMyNamePrint"].Value = elaMyNamePrint;
		dbCommand.Parameters["@elaLikeComeToSchool"].Value = elaLikeComeToSchool;
		dbCommand.Parameters["@elaArticulateWell"].Value = elaArticulateWell;
		dbCommand.Parameters["@elaRecite"].Value = elaRecite;
		dbCommand.Parameters["@elaStoryTell"].Value = elaStoryTell;
		dbCommand.Parameters["@elaExpressIdeas"].Value = elaExpressIdeas;
		dbCommand.Parameters["@elaDevelopeNewWords"].Value = elaDevelopeNewWords;
		dbCommand.Parameters["@elaConverseFairlyWell"].Value = elaConverseFairlyWell;
		dbCommand.Parameters["@elaFormLetters"].Value = elaFormLetters;
		dbCommand.Parameters["@elaMakeSimplePattern"].Value = elaMakeSimplePattern;
		dbCommand.Parameters["@elaAddedByType"].Value = elaAddedByType;
		dbCommand.Parameters["@elaAddedByLoginId"].Value = elaAddedByLoginId;
		dbCommand.Parameters["@elaDate"].Value = elaDate;
		dbCommand.Parameters["@elaStatus"].Value = elaStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? elaAbilityId, System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus)
	{
		Update(elaAbilityId, elaSchoolId, elaSchoolSubId, elaStudentLoginId, elaAllLetters, elaNumbers, elaColours, elaShape, elaVegetableFruits, elaAnimalBirds, elaMeansOfTransport, elaCoomonArticleSchoolHome, elaMyNamePrint, elaLikeComeToSchool, elaArticulateWell, elaRecite, elaStoryTell, elaExpressIdeas, elaDevelopeNewWords, elaConverseFairlyWell, elaFormLetters, elaMakeSimplePattern, elaAddedByType, elaAddedByLoginId, elaDate, elaStatus, null);
	}
	
	public static void Update(TMSEvolutionOfLiteraryAbilities tMSEvolutionOfLiteraryAbilities)
	{
		tMSEvolutionOfLiteraryAbilities.Update();
	}
	
	public static void Update(TMSEvolutionOfLiteraryAbilities tMSEvolutionOfLiteraryAbilities, DbTransaction transaction)
	{
		tMSEvolutionOfLiteraryAbilities.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@elaAbilityId"].SourceColumn = "ELA_AbilityId";
		dbCommand.Parameters["@elaSchoolId"].SourceColumn = "ELA_SchoolId";
		dbCommand.Parameters["@elaSchoolSubId"].SourceColumn = "ELA_SchoolSubId";
		dbCommand.Parameters["@elaStudentLoginId"].SourceColumn = "ELA_StudentLoginId";
		dbCommand.Parameters["@elaAllLetters"].SourceColumn = "ELA_AllLetters";
		dbCommand.Parameters["@elaNumbers"].SourceColumn = "ELA_Numbers";
		dbCommand.Parameters["@elaColours"].SourceColumn = "ELA_Colours";
		dbCommand.Parameters["@elaShape"].SourceColumn = "ELA_Shape";
		dbCommand.Parameters["@elaVegetableFruits"].SourceColumn = "ELA_VegetableFruits";
		dbCommand.Parameters["@elaAnimalBirds"].SourceColumn = "ELA_AnimalBirds";
		dbCommand.Parameters["@elaMeansOfTransport"].SourceColumn = "ELA_MeansOfTransport";
		dbCommand.Parameters["@elaCoomonArticleSchoolHome"].SourceColumn = "ELA_CoomonArticleSchoolHome";
		dbCommand.Parameters["@elaMyNamePrint"].SourceColumn = "ELA_MyNamePrint";
		dbCommand.Parameters["@elaLikeComeToSchool"].SourceColumn = "ELA_LikeComeToSchool";
		dbCommand.Parameters["@elaArticulateWell"].SourceColumn = "ELA_ArticulateWell";
		dbCommand.Parameters["@elaRecite"].SourceColumn = "ELA_Recite";
		dbCommand.Parameters["@elaStoryTell"].SourceColumn = "ELA_StoryTell";
		dbCommand.Parameters["@elaExpressIdeas"].SourceColumn = "ELA_ExpressIdeas";
		dbCommand.Parameters["@elaDevelopeNewWords"].SourceColumn = "ELA_DevelopeNewWords";
		dbCommand.Parameters["@elaConverseFairlyWell"].SourceColumn = "ELA_ConverseFairlyWell";
		dbCommand.Parameters["@elaFormLetters"].SourceColumn = "ELA_FormLetters";
		dbCommand.Parameters["@elaMakeSimplePattern"].SourceColumn = "ELA_MakeSimplePattern";
		dbCommand.Parameters["@elaAddedByType"].SourceColumn = "ELA_AddedByType";
		dbCommand.Parameters["@elaAddedByLoginId"].SourceColumn = "ELA_AddedByLoginId";
		dbCommand.Parameters["@elaDate"].SourceColumn = "ELA_Date";
		dbCommand.Parameters["@elaStatus"].SourceColumn = "ELA_Status";
		
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
	public static void Delete(System.Int64? elaAbilityId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elaAbilityId);
		
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
	public static void Delete(System.Int64? elaAbilityId)
	{
		Delete(
		elaAbilityId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfLiteraryAbilities from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ELAAbilityId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ELAAbilityId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfLiteraryAbilities from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfLiteraryAbilities[] Search(System.Int64? elaAbilityId, System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elaAbilityId, elaSchoolId, elaSchoolSubId, elaStudentLoginId, elaAllLetters, elaNumbers, elaColours, elaShape, elaVegetableFruits, elaAnimalBirds, elaMeansOfTransport, elaCoomonArticleSchoolHome, elaMyNamePrint, elaLikeComeToSchool, elaArticulateWell, elaRecite, elaStoryTell, elaExpressIdeas, elaDevelopeNewWords, elaConverseFairlyWell, elaFormLetters, elaMakeSimplePattern, elaAddedByType, elaAddedByLoginId, elaDate, elaStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfLiteraryAbilities.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfLiteraryAbilities[] Search(TMSEvolutionOfLiteraryAbilities searchObject)
	{
		return Search ( searchObject.ELAAbilityId, searchObject.ELASchoolId, searchObject.ELASchoolSubId, searchObject.ELAStudentLoginId, searchObject.ELAAllLetters, searchObject.ELANumbers, searchObject.ELAColours, searchObject.ELAShape, searchObject.ELAVegetableFruits, searchObject.ELAAnimalBirds, searchObject.ELAMeansOfTransport, searchObject.ELACoomonArticleSchoolHome, searchObject.ELAMyNamePrint, searchObject.ELALikeComeToSchool, searchObject.ELAArticulateWell, searchObject.ELARecite, searchObject.ELAStoryTell, searchObject.ELAExpressIdeas, searchObject.ELADevelopeNewWords, searchObject.ELAConverseFairlyWell, searchObject.ELAFormLetters, searchObject.ELAMakeSimplePattern, searchObject.ELAAddedByType, searchObject.ELAAddedByLoginId, searchObject.ELADate, searchObject.ELAStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfLiteraryAbilities objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfLiteraryAbilities objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfLiteraryAbilities[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

