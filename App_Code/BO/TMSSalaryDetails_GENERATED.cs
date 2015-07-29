/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/23/2012 5:34:08 PM                                    */
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
public partial class TMSSalaryDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SalaryDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _siDetailsId;
	private System.Int64? _siFacultyLoginId;
	private System.String _siFacultyType;
	private System.String _siSalaryType;
	private System.Double? _siBasicSalary;
	private System.Double? _siGrossSalary;
	private System.Int32? _siLeaveCount;
	private System.Double? _siLeaveDeductionAmount;
	private System.String _siMonth;
	private System.String _siYear;
	private System.String _siCurrency;
	private System.Double? _sipfRate;
	private System.Double? _sipfAmount;
	private System.Double? _siesiRate;
	private System.Double? _siesiAmount;
	private System.Int32? _siSetHalfDayHours;
	private System.Int32? _silcelFlexibleHours;
	private System.Int32? _silcelConvertedDays;
	private System.Int32? _silcelcOnvertHalfDay;
	private System.Int32? _silcelConvertFullDay;
	private System.DateTime? _siDate;
	private System.String _siAddedByRemarks;
	private System.Int64? _siAddedById;
	private System.String _siOtherRemarks;
	private System.Int32? _siStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SIDetailsId
	{
		get
		{
			return _siDetailsId;
		}
		set
		{
			_siDetailsId = value;
		}
	}
	
	public System.Int64? SIFacultyLoginId
	{
		get
		{
			return _siFacultyLoginId;
		}
		set
		{
			_siFacultyLoginId = value;
		}
	}
	
	public System.String SIFacultyType
	{
		get
		{
			return _siFacultyType;
		}
		set
		{
			_siFacultyType = value;
		}
	}
	
	public System.String SISalaryType
	{
		get
		{
			return _siSalaryType;
		}
		set
		{
			_siSalaryType = value;
		}
	}
	
	public System.Double? SIBasicSalary
	{
		get
		{
			return _siBasicSalary;
		}
		set
		{
			_siBasicSalary = value;
		}
	}
	
	public System.Double? SIGrossSalary
	{
		get
		{
			return _siGrossSalary;
		}
		set
		{
			_siGrossSalary = value;
		}
	}
	
	public System.Int32? SILeaveCount
	{
		get
		{
			return _siLeaveCount;
		}
		set
		{
			_siLeaveCount = value;
		}
	}
	
	public System.Double? SILeaveDeductionAmount
	{
		get
		{
			return _siLeaveDeductionAmount;
		}
		set
		{
			_siLeaveDeductionAmount = value;
		}
	}
	
	public System.String SIMonth
	{
		get
		{
			return _siMonth;
		}
		set
		{
			_siMonth = value;
		}
	}
	
	public System.String SIYear
	{
		get
		{
			return _siYear;
		}
		set
		{
			_siYear = value;
		}
	}
	
	public System.String SICurrency
	{
		get
		{
			return _siCurrency;
		}
		set
		{
			_siCurrency = value;
		}
	}
	
	public System.Double? SIPFRate
	{
		get
		{
			return _sipfRate;
		}
		set
		{
			_sipfRate = value;
		}
	}
	
	public System.Double? SIPFAmount
	{
		get
		{
			return _sipfAmount;
		}
		set
		{
			_sipfAmount = value;
		}
	}
	
	public System.Double? SIESIRate
	{
		get
		{
			return _siesiRate;
		}
		set
		{
			_siesiRate = value;
		}
	}
	
	public System.Double? SIESIAmount
	{
		get
		{
			return _siesiAmount;
		}
		set
		{
			_siesiAmount = value;
		}
	}
	
	public System.Int32? SISetHalfDayHours
	{
		get
		{
			return _siSetHalfDayHours;
		}
		set
		{
			_siSetHalfDayHours = value;
		}
	}
	
	public System.Int32? SILCELFlexibleHours
	{
		get
		{
			return _silcelFlexibleHours;
		}
		set
		{
			_silcelFlexibleHours = value;
		}
	}
	
	public System.Int32? SILCELConvertedDays
	{
		get
		{
			return _silcelConvertedDays;
		}
		set
		{
			_silcelConvertedDays = value;
		}
	}
	
	public System.Int32? SILCELCOnvertHalfDay
	{
		get
		{
			return _silcelcOnvertHalfDay;
		}
		set
		{
			_silcelcOnvertHalfDay = value;
		}
	}
	
	public System.Int32? SILCELConvertFullDay
	{
		get
		{
			return _silcelConvertFullDay;
		}
		set
		{
			_silcelConvertFullDay = value;
		}
	}
	
	public System.DateTime? SIDate
	{
		get
		{
			return _siDate;
		}
		set
		{
			_siDate = value;
		}
	}
	
	public System.String SIAddedByRemarks
	{
		get
		{
			return _siAddedByRemarks;
		}
		set
		{
			_siAddedByRemarks = value;
		}
	}
	
	public System.Int64? SIAddedById
	{
		get
		{
			return _siAddedById;
		}
		set
		{
			_siAddedById = value;
		}
	}
	
	public System.String SIOtherRemarks
	{
		get
		{
			return _siOtherRemarks;
		}
		set
		{
			_siOtherRemarks = value;
		}
	}
	
	public System.Int32? SIStatus
	{
		get
		{
			return _siStatus;
		}
		set
		{
			_siStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SI_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_FacultyType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_SalaryType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_BasicSalary", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_GrossSalary", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LeaveCount", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LeaveDeductionAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_Currency", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_PFRate", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_PFAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_ESIRate", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_ESIAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_SetHalfDayHours", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LCELFlexibleHours", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LCELConvertedDays", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LCELCOnvertHalfDay", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_LCELConvertFullDay", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_AddedByRemarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_OtherRemarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SI_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SIDetailsId == null)
		dr["SI_DetailsId"] = DBNull.Value;
		else
		dr["SI_DetailsId"] = SIDetailsId;
		
		if (SIFacultyLoginId == null)
		dr["SI_FacultyLoginId"] = DBNull.Value;
		else
		dr["SI_FacultyLoginId"] = SIFacultyLoginId;
		
		if (SIFacultyType == null)
		dr["SI_FacultyType"] = DBNull.Value;
		else
		dr["SI_FacultyType"] = SIFacultyType;
		
		if (SISalaryType == null)
		dr["SI_SalaryType"] = DBNull.Value;
		else
		dr["SI_SalaryType"] = SISalaryType;
		
		if (SIBasicSalary == null)
		dr["SI_BasicSalary"] = DBNull.Value;
		else
		dr["SI_BasicSalary"] = SIBasicSalary;
		
		if (SIGrossSalary == null)
		dr["SI_GrossSalary"] = DBNull.Value;
		else
		dr["SI_GrossSalary"] = SIGrossSalary;
		
		if (SILeaveCount == null)
		dr["SI_LeaveCount"] = DBNull.Value;
		else
		dr["SI_LeaveCount"] = SILeaveCount;
		
		if (SILeaveDeductionAmount == null)
		dr["SI_LeaveDeductionAmount"] = DBNull.Value;
		else
		dr["SI_LeaveDeductionAmount"] = SILeaveDeductionAmount;
		
		if (SIMonth == null)
		dr["SI_Month"] = DBNull.Value;
		else
		dr["SI_Month"] = SIMonth;
		
		if (SIYear == null)
		dr["SI_Year"] = DBNull.Value;
		else
		dr["SI_Year"] = SIYear;
		
		if (SICurrency == null)
		dr["SI_Currency"] = DBNull.Value;
		else
		dr["SI_Currency"] = SICurrency;
		
		if (SIPFRate == null)
		dr["SI_PFRate"] = DBNull.Value;
		else
		dr["SI_PFRate"] = SIPFRate;
		
		if (SIPFAmount == null)
		dr["SI_PFAmount"] = DBNull.Value;
		else
		dr["SI_PFAmount"] = SIPFAmount;
		
		if (SIESIRate == null)
		dr["SI_ESIRate"] = DBNull.Value;
		else
		dr["SI_ESIRate"] = SIESIRate;
		
		if (SIESIAmount == null)
		dr["SI_ESIAmount"] = DBNull.Value;
		else
		dr["SI_ESIAmount"] = SIESIAmount;
		
		if (SISetHalfDayHours == null)
		dr["SI_SetHalfDayHours"] = DBNull.Value;
		else
		dr["SI_SetHalfDayHours"] = SISetHalfDayHours;
		
		if (SILCELFlexibleHours == null)
		dr["SI_LCELFlexibleHours"] = DBNull.Value;
		else
		dr["SI_LCELFlexibleHours"] = SILCELFlexibleHours;
		
		if (SILCELConvertedDays == null)
		dr["SI_LCELConvertedDays"] = DBNull.Value;
		else
		dr["SI_LCELConvertedDays"] = SILCELConvertedDays;
		
		if (SILCELCOnvertHalfDay == null)
		dr["SI_LCELCOnvertHalfDay"] = DBNull.Value;
		else
		dr["SI_LCELCOnvertHalfDay"] = SILCELCOnvertHalfDay;
		
		if (SILCELConvertFullDay == null)
		dr["SI_LCELConvertFullDay"] = DBNull.Value;
		else
		dr["SI_LCELConvertFullDay"] = SILCELConvertFullDay;
		
		if (SIDate == null)
		dr["SI_Date"] = DBNull.Value;
		else
		dr["SI_Date"] = SIDate;
		
		if (SIAddedByRemarks == null)
		dr["SI_AddedByRemarks"] = DBNull.Value;
		else
		dr["SI_AddedByRemarks"] = SIAddedByRemarks;
		
		if (SIAddedById == null)
		dr["SI_AddedById"] = DBNull.Value;
		else
		dr["SI_AddedById"] = SIAddedById;
		
		if (SIOtherRemarks == null)
		dr["SI_OtherRemarks"] = DBNull.Value;
		else
		dr["SI_OtherRemarks"] = SIOtherRemarks;
		
		if (SIStatus == null)
		dr["SI_Status"] = DBNull.Value;
		else
		dr["SI_Status"] = SIStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SIDetailsId = dr["SI_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["SI_DetailsId"]) : SIDetailsId = null;
		SIFacultyLoginId = dr["SI_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["SI_FacultyLoginId"]) : SIFacultyLoginId = null;
		SIFacultyType = dr["SI_FacultyType"] != DBNull.Value ? Convert.ToString(dr["SI_FacultyType"]) : SIFacultyType = null;
		SISalaryType = dr["SI_SalaryType"] != DBNull.Value ? Convert.ToString(dr["SI_SalaryType"]) : SISalaryType = null;
		SIBasicSalary = dr["SI_BasicSalary"] != DBNull.Value ? Convert.ToDouble(dr["SI_BasicSalary"]) : SIBasicSalary = null;
		SIGrossSalary = dr["SI_GrossSalary"] != DBNull.Value ? Convert.ToDouble(dr["SI_GrossSalary"]) : SIGrossSalary = null;
		SILeaveCount = dr["SI_LeaveCount"] != DBNull.Value ? Convert.ToInt32(dr["SI_LeaveCount"]) : SILeaveCount = null;
		SILeaveDeductionAmount = dr["SI_LeaveDeductionAmount"] != DBNull.Value ? Convert.ToDouble(dr["SI_LeaveDeductionAmount"]) : SILeaveDeductionAmount = null;
		SIMonth = dr["SI_Month"] != DBNull.Value ? Convert.ToString(dr["SI_Month"]) : SIMonth = null;
		SIYear = dr["SI_Year"] != DBNull.Value ? Convert.ToString(dr["SI_Year"]) : SIYear = null;
		SICurrency = dr["SI_Currency"] != DBNull.Value ? Convert.ToString(dr["SI_Currency"]) : SICurrency = null;
		SIPFRate = dr["SI_PFRate"] != DBNull.Value ? Convert.ToDouble(dr["SI_PFRate"]) : SIPFRate = null;
		SIPFAmount = dr["SI_PFAmount"] != DBNull.Value ? Convert.ToDouble(dr["SI_PFAmount"]) : SIPFAmount = null;
		SIESIRate = dr["SI_ESIRate"] != DBNull.Value ? Convert.ToDouble(dr["SI_ESIRate"]) : SIESIRate = null;
		SIESIAmount = dr["SI_ESIAmount"] != DBNull.Value ? Convert.ToDouble(dr["SI_ESIAmount"]) : SIESIAmount = null;
		SISetHalfDayHours = dr["SI_SetHalfDayHours"] != DBNull.Value ? Convert.ToInt32(dr["SI_SetHalfDayHours"]) : SISetHalfDayHours = null;
		SILCELFlexibleHours = dr["SI_LCELFlexibleHours"] != DBNull.Value ? Convert.ToInt32(dr["SI_LCELFlexibleHours"]) : SILCELFlexibleHours = null;
		SILCELConvertedDays = dr["SI_LCELConvertedDays"] != DBNull.Value ? Convert.ToInt32(dr["SI_LCELConvertedDays"]) : SILCELConvertedDays = null;
		SILCELCOnvertHalfDay = dr["SI_LCELCOnvertHalfDay"] != DBNull.Value ? Convert.ToInt32(dr["SI_LCELCOnvertHalfDay"]) : SILCELCOnvertHalfDay = null;
		SILCELConvertFullDay = dr["SI_LCELConvertFullDay"] != DBNull.Value ? Convert.ToInt32(dr["SI_LCELConvertFullDay"]) : SILCELConvertFullDay = null;
		SIDate = dr["SI_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SI_Date"]) : SIDate = null;
		SIAddedByRemarks = dr["SI_AddedByRemarks"] != DBNull.Value ? Convert.ToString(dr["SI_AddedByRemarks"]) : SIAddedByRemarks = null;
		SIAddedById = dr["SI_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["SI_AddedById"]) : SIAddedById = null;
		SIOtherRemarks = dr["SI_OtherRemarks"] != DBNull.Value ? Convert.ToString(dr["SI_OtherRemarks"]) : SIOtherRemarks = null;
		SIStatus = dr["SI_Status"] != DBNull.Value ? Convert.ToInt32(dr["SI_Status"]) : SIStatus = null;
	}
	
	public static TMSSalaryDetails[] MapFrom(DataSet ds)
	{
		List<TMSSalaryDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSalaryDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SalaryDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SalaryDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSalaryDetails instance = new TMSSalaryDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSalaryDetails Get(System.Int64 siDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSalaryDetails instance;
		
		
		instance = new TMSSalaryDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, siDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSSalaryDetails ID:" + siDetailsId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, siFacultyLoginId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siCurrency, sipfRate, sipfAmount, siesiRate, siesiAmount, siSetHalfDayHours, silcelFlexibleHours, silcelConvertedDays, silcelcOnvertHalfDay, silcelConvertFullDay, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus);
		
		if (transaction == null)
		this.SIDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SIDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus)
	{
		Insert(siFacultyLoginId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siCurrency, sipfRate, sipfAmount, siesiRate, siesiAmount, siSetHalfDayHours, silcelFlexibleHours, silcelConvertedDays, silcelcOnvertHalfDay, silcelConvertFullDay, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus, null);
	}
	/// <summary>
	/// Insert current TMSSalaryDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SIFacultyLoginId, SIFacultyType, SISalaryType, SIBasicSalary, SIGrossSalary, SILeaveCount, SILeaveDeductionAmount, SIMonth, SIYear, SICurrency, SIPFRate, SIPFAmount, SIESIRate, SIESIAmount, SISetHalfDayHours, SILCELFlexibleHours, SILCELConvertedDays, SILCELCOnvertHalfDay, SILCELConvertFullDay, SIDate, SIAddedByRemarks, SIAddedById, SIOtherRemarks, SIStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSalaryDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? siDetailsId, System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@siDetailsId"].Value = siDetailsId;
		dbCommand.Parameters["@siFacultyLoginId"].Value = siFacultyLoginId;
		dbCommand.Parameters["@siFacultyType"].Value = siFacultyType;
		dbCommand.Parameters["@siSalaryType"].Value = siSalaryType;
		dbCommand.Parameters["@siBasicSalary"].Value = siBasicSalary;
		dbCommand.Parameters["@siGrossSalary"].Value = siGrossSalary;
		dbCommand.Parameters["@siLeaveCount"].Value = siLeaveCount;
		dbCommand.Parameters["@siLeaveDeductionAmount"].Value = siLeaveDeductionAmount;
		dbCommand.Parameters["@siMonth"].Value = siMonth;
		dbCommand.Parameters["@siYear"].Value = siYear;
		dbCommand.Parameters["@siCurrency"].Value = siCurrency;
		dbCommand.Parameters["@sipfRate"].Value = sipfRate;
		dbCommand.Parameters["@sipfAmount"].Value = sipfAmount;
		dbCommand.Parameters["@siesiRate"].Value = siesiRate;
		dbCommand.Parameters["@siesiAmount"].Value = siesiAmount;
		dbCommand.Parameters["@siSetHalfDayHours"].Value = siSetHalfDayHours;
		dbCommand.Parameters["@silcelFlexibleHours"].Value = silcelFlexibleHours;
		dbCommand.Parameters["@silcelConvertedDays"].Value = silcelConvertedDays;
		dbCommand.Parameters["@silcelcOnvertHalfDay"].Value = silcelcOnvertHalfDay;
		dbCommand.Parameters["@silcelConvertFullDay"].Value = silcelConvertFullDay;
		dbCommand.Parameters["@siDate"].Value = siDate;
		dbCommand.Parameters["@siAddedByRemarks"].Value = siAddedByRemarks;
		dbCommand.Parameters["@siAddedById"].Value = siAddedById;
		dbCommand.Parameters["@siOtherRemarks"].Value = siOtherRemarks;
		dbCommand.Parameters["@siStatus"].Value = siStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? siDetailsId, System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus)
	{
		Update(siDetailsId, siFacultyLoginId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siCurrency, sipfRate, sipfAmount, siesiRate, siesiAmount, siSetHalfDayHours, silcelFlexibleHours, silcelConvertedDays, silcelcOnvertHalfDay, silcelConvertFullDay, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus, null);
	}
	
	public static void Update(TMSSalaryDetails tMSSalaryDetails)
	{
		tMSSalaryDetails.Update();
	}
	
	public static void Update(TMSSalaryDetails tMSSalaryDetails, DbTransaction transaction)
	{
		tMSSalaryDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSalaryDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@siDetailsId"].SourceColumn = "SI_DetailsId";
		dbCommand.Parameters["@siFacultyLoginId"].SourceColumn = "SI_FacultyLoginId";
		dbCommand.Parameters["@siFacultyType"].SourceColumn = "SI_FacultyType";
		dbCommand.Parameters["@siSalaryType"].SourceColumn = "SI_SalaryType";
		dbCommand.Parameters["@siBasicSalary"].SourceColumn = "SI_BasicSalary";
		dbCommand.Parameters["@siGrossSalary"].SourceColumn = "SI_GrossSalary";
		dbCommand.Parameters["@siLeaveCount"].SourceColumn = "SI_LeaveCount";
		dbCommand.Parameters["@siLeaveDeductionAmount"].SourceColumn = "SI_LeaveDeductionAmount";
		dbCommand.Parameters["@siMonth"].SourceColumn = "SI_Month";
		dbCommand.Parameters["@siYear"].SourceColumn = "SI_Year";
		dbCommand.Parameters["@siCurrency"].SourceColumn = "SI_Currency";
		dbCommand.Parameters["@sipfRate"].SourceColumn = "SI_PFRate";
		dbCommand.Parameters["@sipfAmount"].SourceColumn = "SI_PFAmount";
		dbCommand.Parameters["@siesiRate"].SourceColumn = "SI_ESIRate";
		dbCommand.Parameters["@siesiAmount"].SourceColumn = "SI_ESIAmount";
		dbCommand.Parameters["@siSetHalfDayHours"].SourceColumn = "SI_SetHalfDayHours";
		dbCommand.Parameters["@silcelFlexibleHours"].SourceColumn = "SI_LCELFlexibleHours";
		dbCommand.Parameters["@silcelConvertedDays"].SourceColumn = "SI_LCELConvertedDays";
		dbCommand.Parameters["@silcelcOnvertHalfDay"].SourceColumn = "SI_LCELCOnvertHalfDay";
		dbCommand.Parameters["@silcelConvertFullDay"].SourceColumn = "SI_LCELConvertFullDay";
		dbCommand.Parameters["@siDate"].SourceColumn = "SI_Date";
		dbCommand.Parameters["@siAddedByRemarks"].SourceColumn = "SI_AddedByRemarks";
		dbCommand.Parameters["@siAddedById"].SourceColumn = "SI_AddedById";
		dbCommand.Parameters["@siOtherRemarks"].SourceColumn = "SI_OtherRemarks";
		dbCommand.Parameters["@siStatus"].SourceColumn = "SI_Status";
		
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
	public static void Delete(System.Int64? siDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, siDetailsId);
		
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
	public static void Delete(System.Int64? siDetailsId)
	{
		Delete(
		siDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSSalaryDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SIDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SIDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSSalaryDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSalaryDetails[] Search(System.Int64? siDetailsId, System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSalaryDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, siDetailsId, siFacultyLoginId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siCurrency, sipfRate, sipfAmount, siesiRate, siesiAmount, siSetHalfDayHours, silcelFlexibleHours, silcelConvertedDays, silcelcOnvertHalfDay, silcelConvertFullDay, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSalaryDetails.MapFrom(ds);
	}
	
	
	public static TMSSalaryDetails[] Search(TMSSalaryDetails searchObject)
	{
		return Search ( searchObject.SIDetailsId, searchObject.SIFacultyLoginId, searchObject.SIFacultyType, searchObject.SISalaryType, searchObject.SIBasicSalary, searchObject.SIGrossSalary, searchObject.SILeaveCount, searchObject.SILeaveDeductionAmount, searchObject.SIMonth, searchObject.SIYear, searchObject.SICurrency, searchObject.SIPFRate, searchObject.SIPFAmount, searchObject.SIESIRate, searchObject.SIESIAmount, searchObject.SISetHalfDayHours, searchObject.SILCELFlexibleHours, searchObject.SILCELConvertedDays, searchObject.SILCELCOnvertHalfDay, searchObject.SILCELConvertFullDay, searchObject.SIDate, searchObject.SIAddedByRemarks, searchObject.SIAddedById, searchObject.SIOtherRemarks, searchObject.SIStatus);
	}
	
	/// <summary>
	/// Returns all TMSSalaryDetails objects.
	/// </summary>
	/// <returns>List of all TMSSalaryDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSalaryDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

