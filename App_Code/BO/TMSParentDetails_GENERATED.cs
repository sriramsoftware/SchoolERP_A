/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSParentDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ParentDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _pdParentId;
	private System.Int64? _pdStudentDetailsId;
	private System.String _pdParentRefId;
	private System.Int64? _pdFatherLoginId;
	private System.Int64? _pdMotherLoginId;
	private System.String _pdFatherFullName;
	private System.String _pdFatherPhoto;
	private System.String _pdFatherEduQualification;
	private System.String _pdFatherOccupation;
	private System.Int64? _pdFatherAddressId;
	private System.String _pdFatherOrgName;
	private System.String _pdFatherDsgtName;
	private System.String _pdMotherFullName;
	private System.String _pdMotherPhoto;
	private System.String _pdMotherEduQualification;
	private System.String _pdMotherOccupation;
	private System.Int64? _pdMotherAddressId;
	private System.String _pdMotherOrgName;
	private System.String _pdMotherDsgtName;
	private System.DateTime? _pdDate;
	private System.Int32? _pdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PDParentId
	{
		get
		{
			return _pdParentId;
		}
		set
		{
			_pdParentId = value;
		}
	}
	
	public System.Int64? PDStudentDetailsId
	{
		get
		{
			return _pdStudentDetailsId;
		}
		set
		{
			_pdStudentDetailsId = value;
		}
	}
	
	public System.String PDParentRefId
	{
		get
		{
			return _pdParentRefId;
		}
		set
		{
			_pdParentRefId = value;
		}
	}
	
	public System.Int64? PDFatherLoginId
	{
		get
		{
			return _pdFatherLoginId;
		}
		set
		{
			_pdFatherLoginId = value;
		}
	}
	
	public System.Int64? PDMotherLoginId
	{
		get
		{
			return _pdMotherLoginId;
		}
		set
		{
			_pdMotherLoginId = value;
		}
	}
	
	public System.String PDFatherFullName
	{
		get
		{
			return _pdFatherFullName;
		}
		set
		{
			_pdFatherFullName = value;
		}
	}
	
	public System.String PDFatherPhoto
	{
		get
		{
			return _pdFatherPhoto;
		}
		set
		{
			_pdFatherPhoto = value;
		}
	}
	
	public System.String PDFatherEduQualification
	{
		get
		{
			return _pdFatherEduQualification;
		}
		set
		{
			_pdFatherEduQualification = value;
		}
	}
	
	public System.String PDFatherOccupation
	{
		get
		{
			return _pdFatherOccupation;
		}
		set
		{
			_pdFatherOccupation = value;
		}
	}
	
	public System.Int64? PDFatherAddressId
	{
		get
		{
			return _pdFatherAddressId;
		}
		set
		{
			_pdFatherAddressId = value;
		}
	}
	
	public System.String PDFatherOrgName
	{
		get
		{
			return _pdFatherOrgName;
		}
		set
		{
			_pdFatherOrgName = value;
		}
	}
	
	public System.String PDFatherDsgtName
	{
		get
		{
			return _pdFatherDsgtName;
		}
		set
		{
			_pdFatherDsgtName = value;
		}
	}
	
	public System.String PDMotherFullName
	{
		get
		{
			return _pdMotherFullName;
		}
		set
		{
			_pdMotherFullName = value;
		}
	}
	
	public System.String PDMotherPhoto
	{
		get
		{
			return _pdMotherPhoto;
		}
		set
		{
			_pdMotherPhoto = value;
		}
	}
	
	public System.String PDMotherEduQualification
	{
		get
		{
			return _pdMotherEduQualification;
		}
		set
		{
			_pdMotherEduQualification = value;
		}
	}
	
	public System.String PDMotherOccupation
	{
		get
		{
			return _pdMotherOccupation;
		}
		set
		{
			_pdMotherOccupation = value;
		}
	}
	
	public System.Int64? PDMotherAddressId
	{
		get
		{
			return _pdMotherAddressId;
		}
		set
		{
			_pdMotherAddressId = value;
		}
	}
	
	public System.String PDMotherOrgName
	{
		get
		{
			return _pdMotherOrgName;
		}
		set
		{
			_pdMotherOrgName = value;
		}
	}
	
	public System.String PDMotherDsgtName
	{
		get
		{
			return _pdMotherDsgtName;
		}
		set
		{
			_pdMotherDsgtName = value;
		}
	}
	
	public System.DateTime? PDDate
	{
		get
		{
			return _pdDate;
		}
		set
		{
			_pdDate = value;
		}
	}
	
	public System.Int32? PDStatus
	{
		get
		{
			return _pdStatus;
		}
		set
		{
			_pdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PD_ParentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_StudentDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_ParentRefId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherFullName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherPhoto", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherEduQualification", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherOccupation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherAddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherOrgName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_FatherDsgtName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherFullName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherPhoto", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherEduQualification", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherOccupation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherAddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherOrgName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_MotherDsgtName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PDParentId == null)
		dr["PD_ParentId"] = DBNull.Value;
		else
		dr["PD_ParentId"] = PDParentId;
		
		if (PDStudentDetailsId == null)
		dr["PD_StudentDetailsId"] = DBNull.Value;
		else
		dr["PD_StudentDetailsId"] = PDStudentDetailsId;
		
		if (PDParentRefId == null)
		dr["PD_ParentRefId"] = DBNull.Value;
		else
		dr["PD_ParentRefId"] = PDParentRefId;
		
		if (PDFatherLoginId == null)
		dr["PD_FatherLoginId"] = DBNull.Value;
		else
		dr["PD_FatherLoginId"] = PDFatherLoginId;
		
		if (PDMotherLoginId == null)
		dr["PD_MotherLoginId"] = DBNull.Value;
		else
		dr["PD_MotherLoginId"] = PDMotherLoginId;
		
		if (PDFatherFullName == null)
		dr["PD_FatherFullName"] = DBNull.Value;
		else
		dr["PD_FatherFullName"] = PDFatherFullName;
		
		if (PDFatherPhoto == null)
		dr["PD_FatherPhoto"] = DBNull.Value;
		else
		dr["PD_FatherPhoto"] = PDFatherPhoto;
		
		if (PDFatherEduQualification == null)
		dr["PD_FatherEduQualification"] = DBNull.Value;
		else
		dr["PD_FatherEduQualification"] = PDFatherEduQualification;
		
		if (PDFatherOccupation == null)
		dr["PD_FatherOccupation"] = DBNull.Value;
		else
		dr["PD_FatherOccupation"] = PDFatherOccupation;
		
		if (PDFatherAddressId == null)
		dr["PD_FatherAddressId"] = DBNull.Value;
		else
		dr["PD_FatherAddressId"] = PDFatherAddressId;
		
		if (PDFatherOrgName == null)
		dr["PD_FatherOrgName"] = DBNull.Value;
		else
		dr["PD_FatherOrgName"] = PDFatherOrgName;
		
		if (PDFatherDsgtName == null)
		dr["PD_FatherDsgtName"] = DBNull.Value;
		else
		dr["PD_FatherDsgtName"] = PDFatherDsgtName;
		
		if (PDMotherFullName == null)
		dr["PD_MotherFullName"] = DBNull.Value;
		else
		dr["PD_MotherFullName"] = PDMotherFullName;
		
		if (PDMotherPhoto == null)
		dr["PD_MotherPhoto"] = DBNull.Value;
		else
		dr["PD_MotherPhoto"] = PDMotherPhoto;
		
		if (PDMotherEduQualification == null)
		dr["PD_MotherEduQualification"] = DBNull.Value;
		else
		dr["PD_MotherEduQualification"] = PDMotherEduQualification;
		
		if (PDMotherOccupation == null)
		dr["PD_MotherOccupation"] = DBNull.Value;
		else
		dr["PD_MotherOccupation"] = PDMotherOccupation;
		
		if (PDMotherAddressId == null)
		dr["PD_MotherAddressId"] = DBNull.Value;
		else
		dr["PD_MotherAddressId"] = PDMotherAddressId;
		
		if (PDMotherOrgName == null)
		dr["PD_MotherOrgName"] = DBNull.Value;
		else
		dr["PD_MotherOrgName"] = PDMotherOrgName;
		
		if (PDMotherDsgtName == null)
		dr["PD_MotherDsgtName"] = DBNull.Value;
		else
		dr["PD_MotherDsgtName"] = PDMotherDsgtName;
		
		if (PDDate == null)
		dr["PD_Date"] = DBNull.Value;
		else
		dr["PD_Date"] = PDDate;
		
		if (PDStatus == null)
		dr["PD_Status"] = DBNull.Value;
		else
		dr["PD_Status"] = PDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PDParentId = dr["PD_ParentId"] != DBNull.Value ? Convert.ToInt64(dr["PD_ParentId"]) : PDParentId = null;
		PDStudentDetailsId = dr["PD_StudentDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["PD_StudentDetailsId"]) : PDStudentDetailsId = null;
		PDParentRefId = dr["PD_ParentRefId"] != DBNull.Value ? Convert.ToString(dr["PD_ParentRefId"]) : PDParentRefId = null;
		PDFatherLoginId = dr["PD_FatherLoginId"] != DBNull.Value ? Convert.ToInt64(dr["PD_FatherLoginId"]) : PDFatherLoginId = null;
		PDMotherLoginId = dr["PD_MotherLoginId"] != DBNull.Value ? Convert.ToInt64(dr["PD_MotherLoginId"]) : PDMotherLoginId = null;
		PDFatherFullName = dr["PD_FatherFullName"] != DBNull.Value ? Convert.ToString(dr["PD_FatherFullName"]) : PDFatherFullName = null;
		PDFatherPhoto = dr["PD_FatherPhoto"] != DBNull.Value ? Convert.ToString(dr["PD_FatherPhoto"]) : PDFatherPhoto = null;
		PDFatherEduQualification = dr["PD_FatherEduQualification"] != DBNull.Value ? Convert.ToString(dr["PD_FatherEduQualification"]) : PDFatherEduQualification = null;
		PDFatherOccupation = dr["PD_FatherOccupation"] != DBNull.Value ? Convert.ToString(dr["PD_FatherOccupation"]) : PDFatherOccupation = null;
		PDFatherAddressId = dr["PD_FatherAddressId"] != DBNull.Value ? Convert.ToInt64(dr["PD_FatherAddressId"]) : PDFatherAddressId = null;
		PDFatherOrgName = dr["PD_FatherOrgName"] != DBNull.Value ? Convert.ToString(dr["PD_FatherOrgName"]) : PDFatherOrgName = null;
		PDFatherDsgtName = dr["PD_FatherDsgtName"] != DBNull.Value ? Convert.ToString(dr["PD_FatherDsgtName"]) : PDFatherDsgtName = null;
		PDMotherFullName = dr["PD_MotherFullName"] != DBNull.Value ? Convert.ToString(dr["PD_MotherFullName"]) : PDMotherFullName = null;
		PDMotherPhoto = dr["PD_MotherPhoto"] != DBNull.Value ? Convert.ToString(dr["PD_MotherPhoto"]) : PDMotherPhoto = null;
		PDMotherEduQualification = dr["PD_MotherEduQualification"] != DBNull.Value ? Convert.ToString(dr["PD_MotherEduQualification"]) : PDMotherEduQualification = null;
		PDMotherOccupation = dr["PD_MotherOccupation"] != DBNull.Value ? Convert.ToString(dr["PD_MotherOccupation"]) : PDMotherOccupation = null;
		PDMotherAddressId = dr["PD_MotherAddressId"] != DBNull.Value ? Convert.ToInt64(dr["PD_MotherAddressId"]) : PDMotherAddressId = null;
		PDMotherOrgName = dr["PD_MotherOrgName"] != DBNull.Value ? Convert.ToString(dr["PD_MotherOrgName"]) : PDMotherOrgName = null;
		PDMotherDsgtName = dr["PD_MotherDsgtName"] != DBNull.Value ? Convert.ToString(dr["PD_MotherDsgtName"]) : PDMotherDsgtName = null;
		PDDate = dr["PD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PD_Date"]) : PDDate = null;
		PDStatus = dr["PD_Status"] != DBNull.Value ? Convert.ToInt32(dr["PD_Status"]) : PDStatus = null;
	}
	
	public static TMSParentDetails[] MapFrom(DataSet ds)
	{
		List<TMSParentDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSParentDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ParentDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ParentDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSParentDetails instance = new TMSParentDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentDetails Get(System.Int64 pdParentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSParentDetails instance;
		
		
		instance = new TMSParentDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pdParentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSParentDetails ID:" + pdParentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pdStudentDetailsId, pdParentRefId, pdFatherLoginId, pdMotherLoginId, pdFatherFullName, pdFatherPhoto, pdFatherEduQualification, pdFatherOccupation, pdFatherAddressId, pdFatherOrgName, pdFatherDsgtName, pdMotherFullName, pdMotherPhoto, pdMotherEduQualification, pdMotherOccupation, pdMotherAddressId, pdMotherOrgName, pdMotherDsgtName, pdDate, pdStatus);
		
		if (transaction == null)
		this.PDParentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PDParentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus)
	{
		Insert(pdStudentDetailsId, pdParentRefId, pdFatherLoginId, pdMotherLoginId, pdFatherFullName, pdFatherPhoto, pdFatherEduQualification, pdFatherOccupation, pdFatherAddressId, pdFatherOrgName, pdFatherDsgtName, pdMotherFullName, pdMotherPhoto, pdMotherEduQualification, pdMotherOccupation, pdMotherAddressId, pdMotherOrgName, pdMotherDsgtName, pdDate, pdStatus, null);
	}
	/// <summary>
	/// Insert current TMSParentDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PDStudentDetailsId, PDParentRefId, PDFatherLoginId, PDMotherLoginId, PDFatherFullName, PDFatherPhoto, PDFatherEduQualification, PDFatherOccupation, PDFatherAddressId, PDFatherOrgName, PDFatherDsgtName, PDMotherFullName, PDMotherPhoto, PDMotherEduQualification, PDMotherOccupation, PDMotherAddressId, PDMotherOrgName, PDMotherDsgtName, PDDate, PDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSParentDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? pdParentId, System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@pdParentId"].Value = pdParentId;
		dbCommand.Parameters["@pdStudentDetailsId"].Value = pdStudentDetailsId;
		dbCommand.Parameters["@pdParentRefId"].Value = pdParentRefId;
		dbCommand.Parameters["@pdFatherLoginId"].Value = pdFatherLoginId;
		dbCommand.Parameters["@pdMotherLoginId"].Value = pdMotherLoginId;
		dbCommand.Parameters["@pdFatherFullName"].Value = pdFatherFullName;
		dbCommand.Parameters["@pdFatherPhoto"].Value = pdFatherPhoto;
		dbCommand.Parameters["@pdFatherEduQualification"].Value = pdFatherEduQualification;
		dbCommand.Parameters["@pdFatherOccupation"].Value = pdFatherOccupation;
		dbCommand.Parameters["@pdFatherAddressId"].Value = pdFatherAddressId;
		dbCommand.Parameters["@pdFatherOrgName"].Value = pdFatherOrgName;
		dbCommand.Parameters["@pdFatherDsgtName"].Value = pdFatherDsgtName;
		dbCommand.Parameters["@pdMotherFullName"].Value = pdMotherFullName;
		dbCommand.Parameters["@pdMotherPhoto"].Value = pdMotherPhoto;
		dbCommand.Parameters["@pdMotherEduQualification"].Value = pdMotherEduQualification;
		dbCommand.Parameters["@pdMotherOccupation"].Value = pdMotherOccupation;
		dbCommand.Parameters["@pdMotherAddressId"].Value = pdMotherAddressId;
		dbCommand.Parameters["@pdMotherOrgName"].Value = pdMotherOrgName;
		dbCommand.Parameters["@pdMotherDsgtName"].Value = pdMotherDsgtName;
		dbCommand.Parameters["@pdDate"].Value = pdDate;
		dbCommand.Parameters["@pdStatus"].Value = pdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? pdParentId, System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus)
	{
		Update(pdParentId, pdStudentDetailsId, pdParentRefId, pdFatherLoginId, pdMotherLoginId, pdFatherFullName, pdFatherPhoto, pdFatherEduQualification, pdFatherOccupation, pdFatherAddressId, pdFatherOrgName, pdFatherDsgtName, pdMotherFullName, pdMotherPhoto, pdMotherEduQualification, pdMotherOccupation, pdMotherAddressId, pdMotherOrgName, pdMotherDsgtName, pdDate, pdStatus, null);
	}
	
	public static void Update(TMSParentDetails tMSParentDetails)
	{
		tMSParentDetails.Update();
	}
	
	public static void Update(TMSParentDetails tMSParentDetails, DbTransaction transaction)
	{
		tMSParentDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSParentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@pdParentId"].SourceColumn = "PD_ParentId";
		dbCommand.Parameters["@pdStudentDetailsId"].SourceColumn = "PD_StudentDetailsId";
		dbCommand.Parameters["@pdParentRefId"].SourceColumn = "PD_ParentRefId";
		dbCommand.Parameters["@pdFatherLoginId"].SourceColumn = "PD_FatherLoginId";
		dbCommand.Parameters["@pdMotherLoginId"].SourceColumn = "PD_MotherLoginId";
		dbCommand.Parameters["@pdFatherFullName"].SourceColumn = "PD_FatherFullName";
		dbCommand.Parameters["@pdFatherPhoto"].SourceColumn = "PD_FatherPhoto";
		dbCommand.Parameters["@pdFatherEduQualification"].SourceColumn = "PD_FatherEduQualification";
		dbCommand.Parameters["@pdFatherOccupation"].SourceColumn = "PD_FatherOccupation";
		dbCommand.Parameters["@pdFatherAddressId"].SourceColumn = "PD_FatherAddressId";
		dbCommand.Parameters["@pdFatherOrgName"].SourceColumn = "PD_FatherOrgName";
		dbCommand.Parameters["@pdFatherDsgtName"].SourceColumn = "PD_FatherDsgtName";
		dbCommand.Parameters["@pdMotherFullName"].SourceColumn = "PD_MotherFullName";
		dbCommand.Parameters["@pdMotherPhoto"].SourceColumn = "PD_MotherPhoto";
		dbCommand.Parameters["@pdMotherEduQualification"].SourceColumn = "PD_MotherEduQualification";
		dbCommand.Parameters["@pdMotherOccupation"].SourceColumn = "PD_MotherOccupation";
		dbCommand.Parameters["@pdMotherAddressId"].SourceColumn = "PD_MotherAddressId";
		dbCommand.Parameters["@pdMotherOrgName"].SourceColumn = "PD_MotherOrgName";
		dbCommand.Parameters["@pdMotherDsgtName"].SourceColumn = "PD_MotherDsgtName";
		dbCommand.Parameters["@pdDate"].SourceColumn = "PD_Date";
		dbCommand.Parameters["@pdStatus"].SourceColumn = "PD_Status";
		
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
	public static void Delete(System.Int64? pdParentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pdParentId);
		
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
	public static void Delete(System.Int64? pdParentId)
	{
		Delete(
		pdParentId);
	}
	
	/// <summary>
	/// Delete current TMSParentDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PDParentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PDParentId = null;
	}
	
	/// <summary>
	/// Delete current TMSParentDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentDetails[] Search(System.Int64? pdParentId, System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pdParentId, pdStudentDetailsId, pdParentRefId, pdFatherLoginId, pdMotherLoginId, pdFatherFullName, pdFatherPhoto, pdFatherEduQualification, pdFatherOccupation, pdFatherAddressId, pdFatherOrgName, pdFatherDsgtName, pdMotherFullName, pdMotherPhoto, pdMotherEduQualification, pdMotherOccupation, pdMotherAddressId, pdMotherOrgName, pdMotherDsgtName, pdDate, pdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSParentDetails.MapFrom(ds);
	}
	
	
	public static TMSParentDetails[] Search(TMSParentDetails searchObject)
	{
		return Search ( searchObject.PDParentId, searchObject.PDStudentDetailsId, searchObject.PDParentRefId, searchObject.PDFatherLoginId, searchObject.PDMotherLoginId, searchObject.PDFatherFullName, searchObject.PDFatherPhoto, searchObject.PDFatherEduQualification, searchObject.PDFatherOccupation, searchObject.PDFatherAddressId, searchObject.PDFatherOrgName, searchObject.PDFatherDsgtName, searchObject.PDMotherFullName, searchObject.PDMotherPhoto, searchObject.PDMotherEduQualification, searchObject.PDMotherOccupation, searchObject.PDMotherAddressId, searchObject.PDMotherOrgName, searchObject.PDMotherDsgtName, searchObject.PDDate, searchObject.PDStatus);
	}
	
	/// <summary>
	/// Returns all TMSParentDetails objects.
	/// </summary>
	/// <returns>List of all TMSParentDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSParentDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

