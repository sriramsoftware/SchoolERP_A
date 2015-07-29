/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/4/2012 5:21:53 PM                                    */
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
public partial class TMSMedicalHistory
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_MedicalHistory]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _mhHistoryId;
	private System.Int64? _mhFacultyId;
	private System.Int64? _mhSudentId;
	private System.Int64? _mhParentId;
	private System.Int32? _mhAsthamaLungProblem;
	private System.Int32? _mhCancer;
	private System.Int32? _mhCardiacDisease;
	private System.Int32? _mhDiabetes;
	private System.Int32? _mhHistoryOfBackPain;
	private System.Int32? _mhHypertension;
	private System.Int32? _mhSymptomsAllergy;
	private System.Int32? _mhSymptomsCardiovascularChestPain;
	private System.Int32? _mhSymptomsConnectiveTiessue;
	private System.Int32? _mhSymptomsDiabetes;
	private System.Int32? _mhSymptomsWeightGainLoss;
	private System.Int32? _mhSymptomsNeurological;
	private System.String _mhMedicationAllergiesList;
	private System.String _mhMedicationAllergiesCurrentList;
	private System.String _mhRiskFallsInjuries;
	private System.String _mhExtra1;
	private System.String _mhExtra2;
	private System.String _mhExtra3;
	private System.DateTime? _mhDate;
	private System.Int32? _mhStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? MHHistoryId
	{
		get
		{
			return _mhHistoryId;
		}
		set
		{
			_mhHistoryId = value;
		}
	}
	
	public System.Int64? MHFacultyId
	{
		get
		{
			return _mhFacultyId;
		}
		set
		{
			_mhFacultyId = value;
		}
	}
	
	public System.Int64? MHSudentId
	{
		get
		{
			return _mhSudentId;
		}
		set
		{
			_mhSudentId = value;
		}
	}
	
	public System.Int64? MHParentId
	{
		get
		{
			return _mhParentId;
		}
		set
		{
			_mhParentId = value;
		}
	}
	
	public System.Int32? MHAsthamaLungProblem
	{
		get
		{
			return _mhAsthamaLungProblem;
		}
		set
		{
			_mhAsthamaLungProblem = value;
		}
	}
	
	public System.Int32? MHCancer
	{
		get
		{
			return _mhCancer;
		}
		set
		{
			_mhCancer = value;
		}
	}
	
	public System.Int32? MHCardiacDisease
	{
		get
		{
			return _mhCardiacDisease;
		}
		set
		{
			_mhCardiacDisease = value;
		}
	}
	
	public System.Int32? MHDiabetes
	{
		get
		{
			return _mhDiabetes;
		}
		set
		{
			_mhDiabetes = value;
		}
	}
	
	public System.Int32? MHHistoryOfBackPain
	{
		get
		{
			return _mhHistoryOfBackPain;
		}
		set
		{
			_mhHistoryOfBackPain = value;
		}
	}
	
	public System.Int32? MHHypertension
	{
		get
		{
			return _mhHypertension;
		}
		set
		{
			_mhHypertension = value;
		}
	}
	
	public System.Int32? MHSymptomsAllergy
	{
		get
		{
			return _mhSymptomsAllergy;
		}
		set
		{
			_mhSymptomsAllergy = value;
		}
	}
	
	public System.Int32? MHSymptomsCardiovascularChestPain
	{
		get
		{
			return _mhSymptomsCardiovascularChestPain;
		}
		set
		{
			_mhSymptomsCardiovascularChestPain = value;
		}
	}
	
	public System.Int32? MHSymptomsConnectiveTiessue
	{
		get
		{
			return _mhSymptomsConnectiveTiessue;
		}
		set
		{
			_mhSymptomsConnectiveTiessue = value;
		}
	}
	
	public System.Int32? MHSymptomsDiabetes
	{
		get
		{
			return _mhSymptomsDiabetes;
		}
		set
		{
			_mhSymptomsDiabetes = value;
		}
	}
	
	public System.Int32? MHSymptomsWeightGainLoss
	{
		get
		{
			return _mhSymptomsWeightGainLoss;
		}
		set
		{
			_mhSymptomsWeightGainLoss = value;
		}
	}
	
	public System.Int32? MHSymptomsNeurological
	{
		get
		{
			return _mhSymptomsNeurological;
		}
		set
		{
			_mhSymptomsNeurological = value;
		}
	}
	
	public System.String MHMedicationAllergiesList
	{
		get
		{
			return _mhMedicationAllergiesList;
		}
		set
		{
			_mhMedicationAllergiesList = value;
		}
	}
	
	public System.String MHMedicationAllergiesCurrentList
	{
		get
		{
			return _mhMedicationAllergiesCurrentList;
		}
		set
		{
			_mhMedicationAllergiesCurrentList = value;
		}
	}
	
	public System.String MHRiskFallsInjuries
	{
		get
		{
			return _mhRiskFallsInjuries;
		}
		set
		{
			_mhRiskFallsInjuries = value;
		}
	}
	
	public System.String MHExtra1
	{
		get
		{
			return _mhExtra1;
		}
		set
		{
			_mhExtra1 = value;
		}
	}
	
	public System.String MHExtra2
	{
		get
		{
			return _mhExtra2;
		}
		set
		{
			_mhExtra2 = value;
		}
	}
	
	public System.String MHExtra3
	{
		get
		{
			return _mhExtra3;
		}
		set
		{
			_mhExtra3 = value;
		}
	}
	
	public System.DateTime? MHDate
	{
		get
		{
			return _mhDate;
		}
		set
		{
			_mhDate = value;
		}
	}
	
	public System.Int32? MHStatus
	{
		get
		{
			return _mhStatus;
		}
		set
		{
			_mhStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("MH_HistoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_ParentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_AsthamaLungProblem", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Cancer", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_CardiacDisease", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Diabetes", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_HistoryOfBackPain", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Hypertension", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsAllergy", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsCardiovascularChestPain", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsConnectiveTiessue", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsDiabetes", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsWeightGainLoss", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_SymptomsNeurological", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_MedicationAllergiesList", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_MedicationAllergiesCurrentList", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_RiskFallsInjuries", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Extra3", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("MH_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (MHHistoryId == null)
		dr["MH_HistoryId"] = DBNull.Value;
		else
		dr["MH_HistoryId"] = MHHistoryId;
		
		if (MHFacultyId == null)
		dr["MH_FacultyId"] = DBNull.Value;
		else
		dr["MH_FacultyId"] = MHFacultyId;
		
		if (MHSudentId == null)
		dr["MH_SudentId"] = DBNull.Value;
		else
		dr["MH_SudentId"] = MHSudentId;
		
		if (MHParentId == null)
		dr["MH_ParentId"] = DBNull.Value;
		else
		dr["MH_ParentId"] = MHParentId;
		
		if (MHAsthamaLungProblem == null)
		dr["MH_AsthamaLungProblem"] = DBNull.Value;
		else
		dr["MH_AsthamaLungProblem"] = MHAsthamaLungProblem;
		
		if (MHCancer == null)
		dr["MH_Cancer"] = DBNull.Value;
		else
		dr["MH_Cancer"] = MHCancer;
		
		if (MHCardiacDisease == null)
		dr["MH_CardiacDisease"] = DBNull.Value;
		else
		dr["MH_CardiacDisease"] = MHCardiacDisease;
		
		if (MHDiabetes == null)
		dr["MH_Diabetes"] = DBNull.Value;
		else
		dr["MH_Diabetes"] = MHDiabetes;
		
		if (MHHistoryOfBackPain == null)
		dr["MH_HistoryOfBackPain"] = DBNull.Value;
		else
		dr["MH_HistoryOfBackPain"] = MHHistoryOfBackPain;
		
		if (MHHypertension == null)
		dr["MH_Hypertension"] = DBNull.Value;
		else
		dr["MH_Hypertension"] = MHHypertension;
		
		if (MHSymptomsAllergy == null)
		dr["MH_SymptomsAllergy"] = DBNull.Value;
		else
		dr["MH_SymptomsAllergy"] = MHSymptomsAllergy;
		
		if (MHSymptomsCardiovascularChestPain == null)
		dr["MH_SymptomsCardiovascularChestPain"] = DBNull.Value;
		else
		dr["MH_SymptomsCardiovascularChestPain"] = MHSymptomsCardiovascularChestPain;
		
		if (MHSymptomsConnectiveTiessue == null)
		dr["MH_SymptomsConnectiveTiessue"] = DBNull.Value;
		else
		dr["MH_SymptomsConnectiveTiessue"] = MHSymptomsConnectiveTiessue;
		
		if (MHSymptomsDiabetes == null)
		dr["MH_SymptomsDiabetes"] = DBNull.Value;
		else
		dr["MH_SymptomsDiabetes"] = MHSymptomsDiabetes;
		
		if (MHSymptomsWeightGainLoss == null)
		dr["MH_SymptomsWeightGainLoss"] = DBNull.Value;
		else
		dr["MH_SymptomsWeightGainLoss"] = MHSymptomsWeightGainLoss;
		
		if (MHSymptomsNeurological == null)
		dr["MH_SymptomsNeurological"] = DBNull.Value;
		else
		dr["MH_SymptomsNeurological"] = MHSymptomsNeurological;
		
		if (MHMedicationAllergiesList == null)
		dr["MH_MedicationAllergiesList"] = DBNull.Value;
		else
		dr["MH_MedicationAllergiesList"] = MHMedicationAllergiesList;
		
		if (MHMedicationAllergiesCurrentList == null)
		dr["MH_MedicationAllergiesCurrentList"] = DBNull.Value;
		else
		dr["MH_MedicationAllergiesCurrentList"] = MHMedicationAllergiesCurrentList;
		
		if (MHRiskFallsInjuries == null)
		dr["MH_RiskFallsInjuries"] = DBNull.Value;
		else
		dr["MH_RiskFallsInjuries"] = MHRiskFallsInjuries;
		
		if (MHExtra1 == null)
		dr["MH_Extra1"] = DBNull.Value;
		else
		dr["MH_Extra1"] = MHExtra1;
		
		if (MHExtra2 == null)
		dr["MH_Extra2"] = DBNull.Value;
		else
		dr["MH_Extra2"] = MHExtra2;
		
		if (MHExtra3 == null)
		dr["MH_Extra3"] = DBNull.Value;
		else
		dr["MH_Extra3"] = MHExtra3;
		
		if (MHDate == null)
		dr["MH_Date"] = DBNull.Value;
		else
		dr["MH_Date"] = MHDate;
		
		if (MHStatus == null)
		dr["MH_Status"] = DBNull.Value;
		else
		dr["MH_Status"] = MHStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		MHHistoryId = dr["MH_HistoryId"] != DBNull.Value ? Convert.ToInt64(dr["MH_HistoryId"]) : MHHistoryId = null;
		MHFacultyId = dr["MH_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["MH_FacultyId"]) : MHFacultyId = null;
		MHSudentId = dr["MH_SudentId"] != DBNull.Value ? Convert.ToInt64(dr["MH_SudentId"]) : MHSudentId = null;
		MHParentId = dr["MH_ParentId"] != DBNull.Value ? Convert.ToInt64(dr["MH_ParentId"]) : MHParentId = null;
		MHAsthamaLungProblem = dr["MH_AsthamaLungProblem"] != DBNull.Value ? Convert.ToInt32(dr["MH_AsthamaLungProblem"]) : MHAsthamaLungProblem = null;
		MHCancer = dr["MH_Cancer"] != DBNull.Value ? Convert.ToInt32(dr["MH_Cancer"]) : MHCancer = null;
		MHCardiacDisease = dr["MH_CardiacDisease"] != DBNull.Value ? Convert.ToInt32(dr["MH_CardiacDisease"]) : MHCardiacDisease = null;
		MHDiabetes = dr["MH_Diabetes"] != DBNull.Value ? Convert.ToInt32(dr["MH_Diabetes"]) : MHDiabetes = null;
		MHHistoryOfBackPain = dr["MH_HistoryOfBackPain"] != DBNull.Value ? Convert.ToInt32(dr["MH_HistoryOfBackPain"]) : MHHistoryOfBackPain = null;
		MHHypertension = dr["MH_Hypertension"] != DBNull.Value ? Convert.ToInt32(dr["MH_Hypertension"]) : MHHypertension = null;
		MHSymptomsAllergy = dr["MH_SymptomsAllergy"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsAllergy"]) : MHSymptomsAllergy = null;
		MHSymptomsCardiovascularChestPain = dr["MH_SymptomsCardiovascularChestPain"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsCardiovascularChestPain"]) : MHSymptomsCardiovascularChestPain = null;
		MHSymptomsConnectiveTiessue = dr["MH_SymptomsConnectiveTiessue"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsConnectiveTiessue"]) : MHSymptomsConnectiveTiessue = null;
		MHSymptomsDiabetes = dr["MH_SymptomsDiabetes"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsDiabetes"]) : MHSymptomsDiabetes = null;
		MHSymptomsWeightGainLoss = dr["MH_SymptomsWeightGainLoss"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsWeightGainLoss"]) : MHSymptomsWeightGainLoss = null;
		MHSymptomsNeurological = dr["MH_SymptomsNeurological"] != DBNull.Value ? Convert.ToInt32(dr["MH_SymptomsNeurological"]) : MHSymptomsNeurological = null;
		MHMedicationAllergiesList = dr["MH_MedicationAllergiesList"] != DBNull.Value ? Convert.ToString(dr["MH_MedicationAllergiesList"]) : MHMedicationAllergiesList = null;
		MHMedicationAllergiesCurrentList = dr["MH_MedicationAllergiesCurrentList"] != DBNull.Value ? Convert.ToString(dr["MH_MedicationAllergiesCurrentList"]) : MHMedicationAllergiesCurrentList = null;
		MHRiskFallsInjuries = dr["MH_RiskFallsInjuries"] != DBNull.Value ? Convert.ToString(dr["MH_RiskFallsInjuries"]) : MHRiskFallsInjuries = null;
		MHExtra1 = dr["MH_Extra1"] != DBNull.Value ? Convert.ToString(dr["MH_Extra1"]) : MHExtra1 = null;
		MHExtra2 = dr["MH_Extra2"] != DBNull.Value ? Convert.ToString(dr["MH_Extra2"]) : MHExtra2 = null;
		MHExtra3 = dr["MH_Extra3"] != DBNull.Value ? Convert.ToString(dr["MH_Extra3"]) : MHExtra3 = null;
		MHDate = dr["MH_Date"] != DBNull.Value ? Convert.ToDateTime(dr["MH_Date"]) : MHDate = null;
		MHStatus = dr["MH_Status"] != DBNull.Value ? Convert.ToInt32(dr["MH_Status"]) : MHStatus = null;
	}
	
	public static TMSMedicalHistory[] MapFrom(DataSet ds)
	{
		List<TMSMedicalHistory> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSMedicalHistory>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_MedicalHistory] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_MedicalHistory] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSMedicalHistory instance = new TMSMedicalHistory();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMedicalHistory Get(System.Int64 mhHistoryId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSMedicalHistory instance;
		
		
		instance = new TMSMedicalHistory();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhHistoryId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSMedicalHistory ID:" + mhHistoryId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhFacultyId, mhSudentId, mhParentId, mhAsthamaLungProblem, mhCancer, mhCardiacDisease, mhDiabetes, mhHistoryOfBackPain, mhHypertension, mhSymptomsAllergy, mhSymptomsCardiovascularChestPain, mhSymptomsConnectiveTiessue, mhSymptomsDiabetes, mhSymptomsWeightGainLoss, mhSymptomsNeurological, mhMedicationAllergiesList, mhMedicationAllergiesCurrentList, mhRiskFallsInjuries, mhExtra1, mhExtra2, mhExtra3, mhDate, mhStatus);
		
		if (transaction == null)
		this.MHHistoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.MHHistoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		Insert(mhFacultyId, mhSudentId, mhParentId, mhAsthamaLungProblem, mhCancer, mhCardiacDisease, mhDiabetes, mhHistoryOfBackPain, mhHypertension, mhSymptomsAllergy, mhSymptomsCardiovascularChestPain, mhSymptomsConnectiveTiessue, mhSymptomsDiabetes, mhSymptomsWeightGainLoss, mhSymptomsNeurological, mhMedicationAllergiesList, mhMedicationAllergiesCurrentList, mhRiskFallsInjuries, mhExtra1, mhExtra2, mhExtra3, mhDate, mhStatus, null);
	}
	/// <summary>
	/// Insert current TMSMedicalHistory to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(MHFacultyId, MHSudentId, MHParentId, MHAsthamaLungProblem, MHCancer, MHCardiacDisease, MHDiabetes, MHHistoryOfBackPain, MHHypertension, MHSymptomsAllergy, MHSymptomsCardiovascularChestPain, MHSymptomsConnectiveTiessue, MHSymptomsDiabetes, MHSymptomsWeightGainLoss, MHSymptomsNeurological, MHMedicationAllergiesList, MHMedicationAllergiesCurrentList, MHRiskFallsInjuries, MHExtra1, MHExtra2, MHExtra3, MHDate, MHStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSMedicalHistory to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? mhHistoryId, System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mhHistoryId"].Value = mhHistoryId;
		dbCommand.Parameters["@mhFacultyId"].Value = mhFacultyId;
		dbCommand.Parameters["@mhSudentId"].Value = mhSudentId;
		dbCommand.Parameters["@mhParentId"].Value = mhParentId;
		dbCommand.Parameters["@mhAsthamaLungProblem"].Value = mhAsthamaLungProblem;
		dbCommand.Parameters["@mhCancer"].Value = mhCancer;
		dbCommand.Parameters["@mhCardiacDisease"].Value = mhCardiacDisease;
		dbCommand.Parameters["@mhDiabetes"].Value = mhDiabetes;
		dbCommand.Parameters["@mhHistoryOfBackPain"].Value = mhHistoryOfBackPain;
		dbCommand.Parameters["@mhHypertension"].Value = mhHypertension;
		dbCommand.Parameters["@mhSymptomsAllergy"].Value = mhSymptomsAllergy;
		dbCommand.Parameters["@mhSymptomsCardiovascularChestPain"].Value = mhSymptomsCardiovascularChestPain;
		dbCommand.Parameters["@mhSymptomsConnectiveTiessue"].Value = mhSymptomsConnectiveTiessue;
		dbCommand.Parameters["@mhSymptomsDiabetes"].Value = mhSymptomsDiabetes;
		dbCommand.Parameters["@mhSymptomsWeightGainLoss"].Value = mhSymptomsWeightGainLoss;
		dbCommand.Parameters["@mhSymptomsNeurological"].Value = mhSymptomsNeurological;
		dbCommand.Parameters["@mhMedicationAllergiesList"].Value = mhMedicationAllergiesList;
		dbCommand.Parameters["@mhMedicationAllergiesCurrentList"].Value = mhMedicationAllergiesCurrentList;
		dbCommand.Parameters["@mhRiskFallsInjuries"].Value = mhRiskFallsInjuries;
		dbCommand.Parameters["@mhExtra1"].Value = mhExtra1;
		dbCommand.Parameters["@mhExtra2"].Value = mhExtra2;
		dbCommand.Parameters["@mhExtra3"].Value = mhExtra3;
		dbCommand.Parameters["@mhDate"].Value = mhDate;
		dbCommand.Parameters["@mhStatus"].Value = mhStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? mhHistoryId, System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		Update(mhHistoryId, mhFacultyId, mhSudentId, mhParentId, mhAsthamaLungProblem, mhCancer, mhCardiacDisease, mhDiabetes, mhHistoryOfBackPain, mhHypertension, mhSymptomsAllergy, mhSymptomsCardiovascularChestPain, mhSymptomsConnectiveTiessue, mhSymptomsDiabetes, mhSymptomsWeightGainLoss, mhSymptomsNeurological, mhMedicationAllergiesList, mhMedicationAllergiesCurrentList, mhRiskFallsInjuries, mhExtra1, mhExtra2, mhExtra3, mhDate, mhStatus, null);
	}
	
	public static void Update(TMSMedicalHistory tMSMedicalHistory)
	{
		tMSMedicalHistory.Update();
	}
	
	public static void Update(TMSMedicalHistory tMSMedicalHistory, DbTransaction transaction)
	{
		tMSMedicalHistory.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSMedicalHistory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mhHistoryId"].SourceColumn = "MH_HistoryId";
		dbCommand.Parameters["@mhFacultyId"].SourceColumn = "MH_FacultyId";
		dbCommand.Parameters["@mhSudentId"].SourceColumn = "MH_SudentId";
		dbCommand.Parameters["@mhParentId"].SourceColumn = "MH_ParentId";
		dbCommand.Parameters["@mhAsthamaLungProblem"].SourceColumn = "MH_AsthamaLungProblem";
		dbCommand.Parameters["@mhCancer"].SourceColumn = "MH_Cancer";
		dbCommand.Parameters["@mhCardiacDisease"].SourceColumn = "MH_CardiacDisease";
		dbCommand.Parameters["@mhDiabetes"].SourceColumn = "MH_Diabetes";
		dbCommand.Parameters["@mhHistoryOfBackPain"].SourceColumn = "MH_HistoryOfBackPain";
		dbCommand.Parameters["@mhHypertension"].SourceColumn = "MH_Hypertension";
		dbCommand.Parameters["@mhSymptomsAllergy"].SourceColumn = "MH_SymptomsAllergy";
		dbCommand.Parameters["@mhSymptomsCardiovascularChestPain"].SourceColumn = "MH_SymptomsCardiovascularChestPain";
		dbCommand.Parameters["@mhSymptomsConnectiveTiessue"].SourceColumn = "MH_SymptomsConnectiveTiessue";
		dbCommand.Parameters["@mhSymptomsDiabetes"].SourceColumn = "MH_SymptomsDiabetes";
		dbCommand.Parameters["@mhSymptomsWeightGainLoss"].SourceColumn = "MH_SymptomsWeightGainLoss";
		dbCommand.Parameters["@mhSymptomsNeurological"].SourceColumn = "MH_SymptomsNeurological";
		dbCommand.Parameters["@mhMedicationAllergiesList"].SourceColumn = "MH_MedicationAllergiesList";
		dbCommand.Parameters["@mhMedicationAllergiesCurrentList"].SourceColumn = "MH_MedicationAllergiesCurrentList";
		dbCommand.Parameters["@mhRiskFallsInjuries"].SourceColumn = "MH_RiskFallsInjuries";
		dbCommand.Parameters["@mhExtra1"].SourceColumn = "MH_Extra1";
		dbCommand.Parameters["@mhExtra2"].SourceColumn = "MH_Extra2";
		dbCommand.Parameters["@mhExtra3"].SourceColumn = "MH_Extra3";
		dbCommand.Parameters["@mhDate"].SourceColumn = "MH_Date";
		dbCommand.Parameters["@mhStatus"].SourceColumn = "MH_Status";
		
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
	public static void Delete(System.Int64? mhHistoryId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhHistoryId);
		
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
	public static void Delete(System.Int64? mhHistoryId)
	{
		Delete(
		mhHistoryId);
	}
	
	/// <summary>
	/// Delete current TMSMedicalHistory from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, MHHistoryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.MHHistoryId = null;
	}
	
	/// <summary>
	/// Delete current TMSMedicalHistory from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMedicalHistory[] Search(System.Int64? mhHistoryId, System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMedicalHistory_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhHistoryId, mhFacultyId, mhSudentId, mhParentId, mhAsthamaLungProblem, mhCancer, mhCardiacDisease, mhDiabetes, mhHistoryOfBackPain, mhHypertension, mhSymptomsAllergy, mhSymptomsCardiovascularChestPain, mhSymptomsConnectiveTiessue, mhSymptomsDiabetes, mhSymptomsWeightGainLoss, mhSymptomsNeurological, mhMedicationAllergiesList, mhMedicationAllergiesCurrentList, mhRiskFallsInjuries, mhExtra1, mhExtra2, mhExtra3, mhDate, mhStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSMedicalHistory.MapFrom(ds);
	}
	
	
	public static TMSMedicalHistory[] Search(TMSMedicalHistory searchObject)
	{
		return Search ( searchObject.MHHistoryId, searchObject.MHFacultyId, searchObject.MHSudentId, searchObject.MHParentId, searchObject.MHAsthamaLungProblem, searchObject.MHCancer, searchObject.MHCardiacDisease, searchObject.MHDiabetes, searchObject.MHHistoryOfBackPain, searchObject.MHHypertension, searchObject.MHSymptomsAllergy, searchObject.MHSymptomsCardiovascularChestPain, searchObject.MHSymptomsConnectiveTiessue, searchObject.MHSymptomsDiabetes, searchObject.MHSymptomsWeightGainLoss, searchObject.MHSymptomsNeurological, searchObject.MHMedicationAllergiesList, searchObject.MHMedicationAllergiesCurrentList, searchObject.MHRiskFallsInjuries, searchObject.MHExtra1, searchObject.MHExtra2, searchObject.MHExtra3, searchObject.MHDate, searchObject.MHStatus);
	}
	
	/// <summary>
	/// Returns all TMSMedicalHistory objects.
	/// </summary>
	/// <returns>List of all TMSMedicalHistory objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSMedicalHistory[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

