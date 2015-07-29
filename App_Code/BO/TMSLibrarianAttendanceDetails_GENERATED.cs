/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/26/2012 5:29:52 PM                                    */
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
public partial class TMSLibrarianAttendanceDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LibrarianAttendanceDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ladAttendancedId;
	private System.Int64? _ladLibraryManagerId;
	private System.Int64? _ladLibrarianId;
	private System.String _ladMonth;
	private System.String _ladYear;
	private System.String _ladOneDate;
	private System.String _ladTwoDate;
	private System.String _ladThreeDate;
	private System.String _ladFourDate;
	private System.String _ladFiveDate;
	private System.String _ladSixDate;
	private System.String _ladSevenDate;
	private System.String _ladEightDate;
	private System.String _ladNineDate;
	private System.String _ladTenDate;
	private System.String _ladElevenDate;
	private System.String _ladTewelDate;
	private System.String _ladThirteenDate;
	private System.String _ladFourteenDate;
	private System.String _ladFifteenDate;
	private System.String _ladSixteenDate;
	private System.String _ladSeventeenDate;
	private System.String _ladEighteenDate;
	private System.String _ladNineteenDate;
	private System.String _ladTwentyDate;
	private System.String _ladTwentyOneDate;
	private System.String _ladTwentyTwoDate;
	private System.String _ladTwentyThreeDate;
	private System.String _ladTwentyFourDate;
	private System.String _ladTwentyFiveDate;
	private System.String _ladTwentySixDate;
	private System.String _ladTwentySevenDate;
	private System.String _ladTwentyEightDate;
	private System.String _ladTwentyNineDate;
	private System.String _ladThirtyDate;
	private System.String _ladThirtyOneDate;
	private System.String _ladAttendanceRemark;
	private System.Int64? _ladAttendanceBy;
	private System.DateTime? _ladDate;
	private System.Int32? _ladStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LADAttendancedId
	{
		get
		{
			return _ladAttendancedId;
		}
		set
		{
			_ladAttendancedId = value;
		}
	}
	
	public System.Int64? LADLibraryManagerId
	{
		get
		{
			return _ladLibraryManagerId;
		}
		set
		{
			_ladLibraryManagerId = value;
		}
	}
	
	public System.Int64? LADLibrarianId
	{
		get
		{
			return _ladLibrarianId;
		}
		set
		{
			_ladLibrarianId = value;
		}
	}
	
	public System.String LADMonth
	{
		get
		{
			return _ladMonth;
		}
		set
		{
			_ladMonth = value;
		}
	}
	
	public System.String LADYear
	{
		get
		{
			return _ladYear;
		}
		set
		{
			_ladYear = value;
		}
	}
	
	public System.String LADOneDate
	{
		get
		{
			return _ladOneDate;
		}
		set
		{
			_ladOneDate = value;
		}
	}
	
	public System.String LADTwoDate
	{
		get
		{
			return _ladTwoDate;
		}
		set
		{
			_ladTwoDate = value;
		}
	}
	
	public System.String LADThreeDate
	{
		get
		{
			return _ladThreeDate;
		}
		set
		{
			_ladThreeDate = value;
		}
	}
	
	public System.String LADFourDate
	{
		get
		{
			return _ladFourDate;
		}
		set
		{
			_ladFourDate = value;
		}
	}
	
	public System.String LADFiveDate
	{
		get
		{
			return _ladFiveDate;
		}
		set
		{
			_ladFiveDate = value;
		}
	}
	
	public System.String LADSixDate
	{
		get
		{
			return _ladSixDate;
		}
		set
		{
			_ladSixDate = value;
		}
	}
	
	public System.String LADSevenDate
	{
		get
		{
			return _ladSevenDate;
		}
		set
		{
			_ladSevenDate = value;
		}
	}
	
	public System.String LADEightDate
	{
		get
		{
			return _ladEightDate;
		}
		set
		{
			_ladEightDate = value;
		}
	}
	
	public System.String LADNineDate
	{
		get
		{
			return _ladNineDate;
		}
		set
		{
			_ladNineDate = value;
		}
	}
	
	public System.String LADTenDate
	{
		get
		{
			return _ladTenDate;
		}
		set
		{
			_ladTenDate = value;
		}
	}
	
	public System.String LADElevenDate
	{
		get
		{
			return _ladElevenDate;
		}
		set
		{
			_ladElevenDate = value;
		}
	}
	
	public System.String LADTewelDate
	{
		get
		{
			return _ladTewelDate;
		}
		set
		{
			_ladTewelDate = value;
		}
	}
	
	public System.String LADThirteenDate
	{
		get
		{
			return _ladThirteenDate;
		}
		set
		{
			_ladThirteenDate = value;
		}
	}
	
	public System.String LADFourteenDate
	{
		get
		{
			return _ladFourteenDate;
		}
		set
		{
			_ladFourteenDate = value;
		}
	}
	
	public System.String LADFifteenDate
	{
		get
		{
			return _ladFifteenDate;
		}
		set
		{
			_ladFifteenDate = value;
		}
	}
	
	public System.String LADSixteenDate
	{
		get
		{
			return _ladSixteenDate;
		}
		set
		{
			_ladSixteenDate = value;
		}
	}
	
	public System.String LADSeventeenDate
	{
		get
		{
			return _ladSeventeenDate;
		}
		set
		{
			_ladSeventeenDate = value;
		}
	}
	
	public System.String LADEighteenDate
	{
		get
		{
			return _ladEighteenDate;
		}
		set
		{
			_ladEighteenDate = value;
		}
	}
	
	public System.String LADNineteenDate
	{
		get
		{
			return _ladNineteenDate;
		}
		set
		{
			_ladNineteenDate = value;
		}
	}
	
	public System.String LADTwentyDate
	{
		get
		{
			return _ladTwentyDate;
		}
		set
		{
			_ladTwentyDate = value;
		}
	}
	
	public System.String LADTwentyOneDate
	{
		get
		{
			return _ladTwentyOneDate;
		}
		set
		{
			_ladTwentyOneDate = value;
		}
	}
	
	public System.String LADTwentyTwoDate
	{
		get
		{
			return _ladTwentyTwoDate;
		}
		set
		{
			_ladTwentyTwoDate = value;
		}
	}
	
	public System.String LADTwentyThreeDate
	{
		get
		{
			return _ladTwentyThreeDate;
		}
		set
		{
			_ladTwentyThreeDate = value;
		}
	}
	
	public System.String LADTwentyFourDate
	{
		get
		{
			return _ladTwentyFourDate;
		}
		set
		{
			_ladTwentyFourDate = value;
		}
	}
	
	public System.String LADTwentyFiveDate
	{
		get
		{
			return _ladTwentyFiveDate;
		}
		set
		{
			_ladTwentyFiveDate = value;
		}
	}
	
	public System.String LADTwentySixDate
	{
		get
		{
			return _ladTwentySixDate;
		}
		set
		{
			_ladTwentySixDate = value;
		}
	}
	
	public System.String LADTwentySevenDate
	{
		get
		{
			return _ladTwentySevenDate;
		}
		set
		{
			_ladTwentySevenDate = value;
		}
	}
	
	public System.String LADTwentyEightDate
	{
		get
		{
			return _ladTwentyEightDate;
		}
		set
		{
			_ladTwentyEightDate = value;
		}
	}
	
	public System.String LADTwentyNineDate
	{
		get
		{
			return _ladTwentyNineDate;
		}
		set
		{
			_ladTwentyNineDate = value;
		}
	}
	
	public System.String LADThirtyDate
	{
		get
		{
			return _ladThirtyDate;
		}
		set
		{
			_ladThirtyDate = value;
		}
	}
	
	public System.String LADThirtyOneDate
	{
		get
		{
			return _ladThirtyOneDate;
		}
		set
		{
			_ladThirtyOneDate = value;
		}
	}
	
	public System.String LADAttendanceRemark
	{
		get
		{
			return _ladAttendanceRemark;
		}
		set
		{
			_ladAttendanceRemark = value;
		}
	}
	
	public System.Int64? LADAttendanceBy
	{
		get
		{
			return _ladAttendanceBy;
		}
		set
		{
			_ladAttendanceBy = value;
		}
	}
	
	public System.DateTime? LADDate
	{
		get
		{
			return _ladDate;
		}
		set
		{
			_ladDate = value;
		}
	}
	
	public System.Int32? LADStatus
	{
		get
		{
			return _ladStatus;
		}
		set
		{
			_ladStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LAD_AttendancedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_LibraryManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_LibrarianId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_OneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwoDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_ThreeDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FourDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FiveDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_SixDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_SevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_EightDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_NineDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_ElevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TewelDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_ThirteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FourteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_FifteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_SixteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_SeventeenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_EighteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_NineteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyOneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyTwoDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyThreeDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyFourDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyFiveDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentySixDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentySevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyEightDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_TwentyNineDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_ThirtyDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_ThirtyOneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_AttendanceRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_AttendanceBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LADAttendancedId == null)
		dr["LAD_AttendancedId"] = DBNull.Value;
		else
		dr["LAD_AttendancedId"] = LADAttendancedId;
		
		if (LADLibraryManagerId == null)
		dr["LAD_LibraryManagerId"] = DBNull.Value;
		else
		dr["LAD_LibraryManagerId"] = LADLibraryManagerId;
		
		if (LADLibrarianId == null)
		dr["LAD_LibrarianId"] = DBNull.Value;
		else
		dr["LAD_LibrarianId"] = LADLibrarianId;
		
		if (LADMonth == null)
		dr["LAD_Month"] = DBNull.Value;
		else
		dr["LAD_Month"] = LADMonth;
		
		if (LADYear == null)
		dr["LAD_Year"] = DBNull.Value;
		else
		dr["LAD_Year"] = LADYear;
		
		if (LADOneDate == null)
		dr["LAD_OneDate"] = DBNull.Value;
		else
		dr["LAD_OneDate"] = LADOneDate;
		
		if (LADTwoDate == null)
		dr["LAD_TwoDate"] = DBNull.Value;
		else
		dr["LAD_TwoDate"] = LADTwoDate;
		
		if (LADThreeDate == null)
		dr["LAD_ThreeDate"] = DBNull.Value;
		else
		dr["LAD_ThreeDate"] = LADThreeDate;
		
		if (LADFourDate == null)
		dr["LAD_FourDate"] = DBNull.Value;
		else
		dr["LAD_FourDate"] = LADFourDate;
		
		if (LADFiveDate == null)
		dr["LAD_FiveDate"] = DBNull.Value;
		else
		dr["LAD_FiveDate"] = LADFiveDate;
		
		if (LADSixDate == null)
		dr["LAD_SixDate"] = DBNull.Value;
		else
		dr["LAD_SixDate"] = LADSixDate;
		
		if (LADSevenDate == null)
		dr["LAD_SevenDate"] = DBNull.Value;
		else
		dr["LAD_SevenDate"] = LADSevenDate;
		
		if (LADEightDate == null)
		dr["LAD_EightDate"] = DBNull.Value;
		else
		dr["LAD_EightDate"] = LADEightDate;
		
		if (LADNineDate == null)
		dr["LAD_NineDate"] = DBNull.Value;
		else
		dr["LAD_NineDate"] = LADNineDate;
		
		if (LADTenDate == null)
		dr["LAD_TenDate"] = DBNull.Value;
		else
		dr["LAD_TenDate"] = LADTenDate;
		
		if (LADElevenDate == null)
		dr["LAD_ElevenDate"] = DBNull.Value;
		else
		dr["LAD_ElevenDate"] = LADElevenDate;
		
		if (LADTewelDate == null)
		dr["LAD_TewelDate"] = DBNull.Value;
		else
		dr["LAD_TewelDate"] = LADTewelDate;
		
		if (LADThirteenDate == null)
		dr["LAD_ThirteenDate"] = DBNull.Value;
		else
		dr["LAD_ThirteenDate"] = LADThirteenDate;
		
		if (LADFourteenDate == null)
		dr["LAD_FourteenDate"] = DBNull.Value;
		else
		dr["LAD_FourteenDate"] = LADFourteenDate;
		
		if (LADFifteenDate == null)
		dr["LAD_FifteenDate"] = DBNull.Value;
		else
		dr["LAD_FifteenDate"] = LADFifteenDate;
		
		if (LADSixteenDate == null)
		dr["LAD_SixteenDate"] = DBNull.Value;
		else
		dr["LAD_SixteenDate"] = LADSixteenDate;
		
		if (LADSeventeenDate == null)
		dr["LAD_SeventeenDate"] = DBNull.Value;
		else
		dr["LAD_SeventeenDate"] = LADSeventeenDate;
		
		if (LADEighteenDate == null)
		dr["LAD_EighteenDate"] = DBNull.Value;
		else
		dr["LAD_EighteenDate"] = LADEighteenDate;
		
		if (LADNineteenDate == null)
		dr["LAD_NineteenDate"] = DBNull.Value;
		else
		dr["LAD_NineteenDate"] = LADNineteenDate;
		
		if (LADTwentyDate == null)
		dr["LAD_TwentyDate"] = DBNull.Value;
		else
		dr["LAD_TwentyDate"] = LADTwentyDate;
		
		if (LADTwentyOneDate == null)
		dr["LAD_TwentyOneDate"] = DBNull.Value;
		else
		dr["LAD_TwentyOneDate"] = LADTwentyOneDate;
		
		if (LADTwentyTwoDate == null)
		dr["LAD_TwentyTwoDate"] = DBNull.Value;
		else
		dr["LAD_TwentyTwoDate"] = LADTwentyTwoDate;
		
		if (LADTwentyThreeDate == null)
		dr["LAD_TwentyThreeDate"] = DBNull.Value;
		else
		dr["LAD_TwentyThreeDate"] = LADTwentyThreeDate;
		
		if (LADTwentyFourDate == null)
		dr["LAD_TwentyFourDate"] = DBNull.Value;
		else
		dr["LAD_TwentyFourDate"] = LADTwentyFourDate;
		
		if (LADTwentyFiveDate == null)
		dr["LAD_TwentyFiveDate"] = DBNull.Value;
		else
		dr["LAD_TwentyFiveDate"] = LADTwentyFiveDate;
		
		if (LADTwentySixDate == null)
		dr["LAD_TwentySixDate"] = DBNull.Value;
		else
		dr["LAD_TwentySixDate"] = LADTwentySixDate;
		
		if (LADTwentySevenDate == null)
		dr["LAD_TwentySevenDate"] = DBNull.Value;
		else
		dr["LAD_TwentySevenDate"] = LADTwentySevenDate;
		
		if (LADTwentyEightDate == null)
		dr["LAD_TwentyEightDate"] = DBNull.Value;
		else
		dr["LAD_TwentyEightDate"] = LADTwentyEightDate;
		
		if (LADTwentyNineDate == null)
		dr["LAD_TwentyNineDate"] = DBNull.Value;
		else
		dr["LAD_TwentyNineDate"] = LADTwentyNineDate;
		
		if (LADThirtyDate == null)
		dr["LAD_ThirtyDate"] = DBNull.Value;
		else
		dr["LAD_ThirtyDate"] = LADThirtyDate;
		
		if (LADThirtyOneDate == null)
		dr["LAD_ThirtyOneDate"] = DBNull.Value;
		else
		dr["LAD_ThirtyOneDate"] = LADThirtyOneDate;
		
		if (LADAttendanceRemark == null)
		dr["LAD_AttendanceRemark"] = DBNull.Value;
		else
		dr["LAD_AttendanceRemark"] = LADAttendanceRemark;
		
		if (LADAttendanceBy == null)
		dr["LAD_AttendanceBy"] = DBNull.Value;
		else
		dr["LAD_AttendanceBy"] = LADAttendanceBy;
		
		if (LADDate == null)
		dr["LAD_Date"] = DBNull.Value;
		else
		dr["LAD_Date"] = LADDate;
		
		if (LADStatus == null)
		dr["LAD_Status"] = DBNull.Value;
		else
		dr["LAD_Status"] = LADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LADAttendancedId = dr["LAD_AttendancedId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_AttendancedId"]) : LADAttendancedId = null;
		LADLibraryManagerId = dr["LAD_LibraryManagerId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_LibraryManagerId"]) : LADLibraryManagerId = null;
		LADLibrarianId = dr["LAD_LibrarianId"] != DBNull.Value ? Convert.ToInt64(dr["LAD_LibrarianId"]) : LADLibrarianId = null;
		LADMonth = dr["LAD_Month"] != DBNull.Value ? Convert.ToString(dr["LAD_Month"]) : LADMonth = null;
		LADYear = dr["LAD_Year"] != DBNull.Value ? Convert.ToString(dr["LAD_Year"]) : LADYear = null;
		LADOneDate = dr["LAD_OneDate"] != DBNull.Value ? Convert.ToString(dr["LAD_OneDate"]) : LADOneDate = null;
		LADTwoDate = dr["LAD_TwoDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwoDate"]) : LADTwoDate = null;
		LADThreeDate = dr["LAD_ThreeDate"] != DBNull.Value ? Convert.ToString(dr["LAD_ThreeDate"]) : LADThreeDate = null;
		LADFourDate = dr["LAD_FourDate"] != DBNull.Value ? Convert.ToString(dr["LAD_FourDate"]) : LADFourDate = null;
		LADFiveDate = dr["LAD_FiveDate"] != DBNull.Value ? Convert.ToString(dr["LAD_FiveDate"]) : LADFiveDate = null;
		LADSixDate = dr["LAD_SixDate"] != DBNull.Value ? Convert.ToString(dr["LAD_SixDate"]) : LADSixDate = null;
		LADSevenDate = dr["LAD_SevenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_SevenDate"]) : LADSevenDate = null;
		LADEightDate = dr["LAD_EightDate"] != DBNull.Value ? Convert.ToString(dr["LAD_EightDate"]) : LADEightDate = null;
		LADNineDate = dr["LAD_NineDate"] != DBNull.Value ? Convert.ToString(dr["LAD_NineDate"]) : LADNineDate = null;
		LADTenDate = dr["LAD_TenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TenDate"]) : LADTenDate = null;
		LADElevenDate = dr["LAD_ElevenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_ElevenDate"]) : LADElevenDate = null;
		LADTewelDate = dr["LAD_TewelDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TewelDate"]) : LADTewelDate = null;
		LADThirteenDate = dr["LAD_ThirteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_ThirteenDate"]) : LADThirteenDate = null;
		LADFourteenDate = dr["LAD_FourteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_FourteenDate"]) : LADFourteenDate = null;
		LADFifteenDate = dr["LAD_FifteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_FifteenDate"]) : LADFifteenDate = null;
		LADSixteenDate = dr["LAD_SixteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_SixteenDate"]) : LADSixteenDate = null;
		LADSeventeenDate = dr["LAD_SeventeenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_SeventeenDate"]) : LADSeventeenDate = null;
		LADEighteenDate = dr["LAD_EighteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_EighteenDate"]) : LADEighteenDate = null;
		LADNineteenDate = dr["LAD_NineteenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_NineteenDate"]) : LADNineteenDate = null;
		LADTwentyDate = dr["LAD_TwentyDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyDate"]) : LADTwentyDate = null;
		LADTwentyOneDate = dr["LAD_TwentyOneDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyOneDate"]) : LADTwentyOneDate = null;
		LADTwentyTwoDate = dr["LAD_TwentyTwoDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyTwoDate"]) : LADTwentyTwoDate = null;
		LADTwentyThreeDate = dr["LAD_TwentyThreeDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyThreeDate"]) : LADTwentyThreeDate = null;
		LADTwentyFourDate = dr["LAD_TwentyFourDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyFourDate"]) : LADTwentyFourDate = null;
		LADTwentyFiveDate = dr["LAD_TwentyFiveDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyFiveDate"]) : LADTwentyFiveDate = null;
		LADTwentySixDate = dr["LAD_TwentySixDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentySixDate"]) : LADTwentySixDate = null;
		LADTwentySevenDate = dr["LAD_TwentySevenDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentySevenDate"]) : LADTwentySevenDate = null;
		LADTwentyEightDate = dr["LAD_TwentyEightDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyEightDate"]) : LADTwentyEightDate = null;
		LADTwentyNineDate = dr["LAD_TwentyNineDate"] != DBNull.Value ? Convert.ToString(dr["LAD_TwentyNineDate"]) : LADTwentyNineDate = null;
		LADThirtyDate = dr["LAD_ThirtyDate"] != DBNull.Value ? Convert.ToString(dr["LAD_ThirtyDate"]) : LADThirtyDate = null;
		LADThirtyOneDate = dr["LAD_ThirtyOneDate"] != DBNull.Value ? Convert.ToString(dr["LAD_ThirtyOneDate"]) : LADThirtyOneDate = null;
		LADAttendanceRemark = dr["LAD_AttendanceRemark"] != DBNull.Value ? Convert.ToString(dr["LAD_AttendanceRemark"]) : LADAttendanceRemark = null;
		LADAttendanceBy = dr["LAD_AttendanceBy"] != DBNull.Value ? Convert.ToInt64(dr["LAD_AttendanceBy"]) : LADAttendanceBy = null;
		LADDate = dr["LAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LAD_Date"]) : LADDate = null;
		LADStatus = dr["LAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LAD_Status"]) : LADStatus = null;
	}
	
	public static TMSLibrarianAttendanceDetails[] MapFrom(DataSet ds)
	{
		List<TMSLibrarianAttendanceDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLibrarianAttendanceDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LibrarianAttendanceDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LibrarianAttendanceDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLibrarianAttendanceDetails instance = new TMSLibrarianAttendanceDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrarianAttendanceDetails Get(System.Int64 ladAttendancedId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLibrarianAttendanceDetails instance;
		
		
		instance = new TMSLibrarianAttendanceDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladAttendancedId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLibrarianAttendanceDetails ID:" + ladAttendancedId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladLibraryManagerId, ladLibrarianId, ladMonth, ladYear, ladOneDate, ladTwoDate, ladThreeDate, ladFourDate, ladFiveDate, ladSixDate, ladSevenDate, ladEightDate, ladNineDate, ladTenDate, ladElevenDate, ladTewelDate, ladThirteenDate, ladFourteenDate, ladFifteenDate, ladSixteenDate, ladSeventeenDate, ladEighteenDate, ladNineteenDate, ladTwentyDate, ladTwentyOneDate, ladTwentyTwoDate, ladTwentyThreeDate, ladTwentyFourDate, ladTwentyFiveDate, ladTwentySixDate, ladTwentySevenDate, ladTwentyEightDate, ladTwentyNineDate, ladThirtyDate, ladThirtyOneDate, ladAttendanceRemark, ladAttendanceBy, ladDate, ladStatus);
		
		if (transaction == null)
		this.LADAttendancedId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LADAttendancedId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		Insert(ladLibraryManagerId, ladLibrarianId, ladMonth, ladYear, ladOneDate, ladTwoDate, ladThreeDate, ladFourDate, ladFiveDate, ladSixDate, ladSevenDate, ladEightDate, ladNineDate, ladTenDate, ladElevenDate, ladTewelDate, ladThirteenDate, ladFourteenDate, ladFifteenDate, ladSixteenDate, ladSeventeenDate, ladEighteenDate, ladNineteenDate, ladTwentyDate, ladTwentyOneDate, ladTwentyTwoDate, ladTwentyThreeDate, ladTwentyFourDate, ladTwentyFiveDate, ladTwentySixDate, ladTwentySevenDate, ladTwentyEightDate, ladTwentyNineDate, ladThirtyDate, ladThirtyOneDate, ladAttendanceRemark, ladAttendanceBy, ladDate, ladStatus, null);
	}
	/// <summary>
	/// Insert current TMSLibrarianAttendanceDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LADLibraryManagerId, LADLibrarianId, LADMonth, LADYear, LADOneDate, LADTwoDate, LADThreeDate, LADFourDate, LADFiveDate, LADSixDate, LADSevenDate, LADEightDate, LADNineDate, LADTenDate, LADElevenDate, LADTewelDate, LADThirteenDate, LADFourteenDate, LADFifteenDate, LADSixteenDate, LADSeventeenDate, LADEighteenDate, LADNineteenDate, LADTwentyDate, LADTwentyOneDate, LADTwentyTwoDate, LADTwentyThreeDate, LADTwentyFourDate, LADTwentyFiveDate, LADTwentySixDate, LADTwentySevenDate, LADTwentyEightDate, LADTwentyNineDate, LADThirtyDate, LADThirtyOneDate, LADAttendanceRemark, LADAttendanceBy, LADDate, LADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLibrarianAttendanceDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ladAttendancedId, System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ladAttendancedId"].Value = ladAttendancedId;
		dbCommand.Parameters["@ladLibraryManagerId"].Value = ladLibraryManagerId;
		dbCommand.Parameters["@ladLibrarianId"].Value = ladLibrarianId;
		dbCommand.Parameters["@ladMonth"].Value = ladMonth;
		dbCommand.Parameters["@ladYear"].Value = ladYear;
		dbCommand.Parameters["@ladOneDate"].Value = ladOneDate;
		dbCommand.Parameters["@ladTwoDate"].Value = ladTwoDate;
		dbCommand.Parameters["@ladThreeDate"].Value = ladThreeDate;
		dbCommand.Parameters["@ladFourDate"].Value = ladFourDate;
		dbCommand.Parameters["@ladFiveDate"].Value = ladFiveDate;
		dbCommand.Parameters["@ladSixDate"].Value = ladSixDate;
		dbCommand.Parameters["@ladSevenDate"].Value = ladSevenDate;
		dbCommand.Parameters["@ladEightDate"].Value = ladEightDate;
		dbCommand.Parameters["@ladNineDate"].Value = ladNineDate;
		dbCommand.Parameters["@ladTenDate"].Value = ladTenDate;
		dbCommand.Parameters["@ladElevenDate"].Value = ladElevenDate;
		dbCommand.Parameters["@ladTewelDate"].Value = ladTewelDate;
		dbCommand.Parameters["@ladThirteenDate"].Value = ladThirteenDate;
		dbCommand.Parameters["@ladFourteenDate"].Value = ladFourteenDate;
		dbCommand.Parameters["@ladFifteenDate"].Value = ladFifteenDate;
		dbCommand.Parameters["@ladSixteenDate"].Value = ladSixteenDate;
		dbCommand.Parameters["@ladSeventeenDate"].Value = ladSeventeenDate;
		dbCommand.Parameters["@ladEighteenDate"].Value = ladEighteenDate;
		dbCommand.Parameters["@ladNineteenDate"].Value = ladNineteenDate;
		dbCommand.Parameters["@ladTwentyDate"].Value = ladTwentyDate;
		dbCommand.Parameters["@ladTwentyOneDate"].Value = ladTwentyOneDate;
		dbCommand.Parameters["@ladTwentyTwoDate"].Value = ladTwentyTwoDate;
		dbCommand.Parameters["@ladTwentyThreeDate"].Value = ladTwentyThreeDate;
		dbCommand.Parameters["@ladTwentyFourDate"].Value = ladTwentyFourDate;
		dbCommand.Parameters["@ladTwentyFiveDate"].Value = ladTwentyFiveDate;
		dbCommand.Parameters["@ladTwentySixDate"].Value = ladTwentySixDate;
		dbCommand.Parameters["@ladTwentySevenDate"].Value = ladTwentySevenDate;
		dbCommand.Parameters["@ladTwentyEightDate"].Value = ladTwentyEightDate;
		dbCommand.Parameters["@ladTwentyNineDate"].Value = ladTwentyNineDate;
		dbCommand.Parameters["@ladThirtyDate"].Value = ladThirtyDate;
		dbCommand.Parameters["@ladThirtyOneDate"].Value = ladThirtyOneDate;
		dbCommand.Parameters["@ladAttendanceRemark"].Value = ladAttendanceRemark;
		dbCommand.Parameters["@ladAttendanceBy"].Value = ladAttendanceBy;
		dbCommand.Parameters["@ladDate"].Value = ladDate;
		dbCommand.Parameters["@ladStatus"].Value = ladStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ladAttendancedId, System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		Update(ladAttendancedId, ladLibraryManagerId, ladLibrarianId, ladMonth, ladYear, ladOneDate, ladTwoDate, ladThreeDate, ladFourDate, ladFiveDate, ladSixDate, ladSevenDate, ladEightDate, ladNineDate, ladTenDate, ladElevenDate, ladTewelDate, ladThirteenDate, ladFourteenDate, ladFifteenDate, ladSixteenDate, ladSeventeenDate, ladEighteenDate, ladNineteenDate, ladTwentyDate, ladTwentyOneDate, ladTwentyTwoDate, ladTwentyThreeDate, ladTwentyFourDate, ladTwentyFiveDate, ladTwentySixDate, ladTwentySevenDate, ladTwentyEightDate, ladTwentyNineDate, ladThirtyDate, ladThirtyOneDate, ladAttendanceRemark, ladAttendanceBy, ladDate, ladStatus, null);
	}
	
	public static void Update(TMSLibrarianAttendanceDetails tMSLibrarianAttendanceDetails)
	{
		tMSLibrarianAttendanceDetails.Update();
	}
	
	public static void Update(TMSLibrarianAttendanceDetails tMSLibrarianAttendanceDetails, DbTransaction transaction)
	{
		tMSLibrarianAttendanceDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ladAttendancedId"].SourceColumn = "LAD_AttendancedId";
		dbCommand.Parameters["@ladLibraryManagerId"].SourceColumn = "LAD_LibraryManagerId";
		dbCommand.Parameters["@ladLibrarianId"].SourceColumn = "LAD_LibrarianId";
		dbCommand.Parameters["@ladMonth"].SourceColumn = "LAD_Month";
		dbCommand.Parameters["@ladYear"].SourceColumn = "LAD_Year";
		dbCommand.Parameters["@ladOneDate"].SourceColumn = "LAD_OneDate";
		dbCommand.Parameters["@ladTwoDate"].SourceColumn = "LAD_TwoDate";
		dbCommand.Parameters["@ladThreeDate"].SourceColumn = "LAD_ThreeDate";
		dbCommand.Parameters["@ladFourDate"].SourceColumn = "LAD_FourDate";
		dbCommand.Parameters["@ladFiveDate"].SourceColumn = "LAD_FiveDate";
		dbCommand.Parameters["@ladSixDate"].SourceColumn = "LAD_SixDate";
		dbCommand.Parameters["@ladSevenDate"].SourceColumn = "LAD_SevenDate";
		dbCommand.Parameters["@ladEightDate"].SourceColumn = "LAD_EightDate";
		dbCommand.Parameters["@ladNineDate"].SourceColumn = "LAD_NineDate";
		dbCommand.Parameters["@ladTenDate"].SourceColumn = "LAD_TenDate";
		dbCommand.Parameters["@ladElevenDate"].SourceColumn = "LAD_ElevenDate";
		dbCommand.Parameters["@ladTewelDate"].SourceColumn = "LAD_TewelDate";
		dbCommand.Parameters["@ladThirteenDate"].SourceColumn = "LAD_ThirteenDate";
		dbCommand.Parameters["@ladFourteenDate"].SourceColumn = "LAD_FourteenDate";
		dbCommand.Parameters["@ladFifteenDate"].SourceColumn = "LAD_FifteenDate";
		dbCommand.Parameters["@ladSixteenDate"].SourceColumn = "LAD_SixteenDate";
		dbCommand.Parameters["@ladSeventeenDate"].SourceColumn = "LAD_SeventeenDate";
		dbCommand.Parameters["@ladEighteenDate"].SourceColumn = "LAD_EighteenDate";
		dbCommand.Parameters["@ladNineteenDate"].SourceColumn = "LAD_NineteenDate";
		dbCommand.Parameters["@ladTwentyDate"].SourceColumn = "LAD_TwentyDate";
		dbCommand.Parameters["@ladTwentyOneDate"].SourceColumn = "LAD_TwentyOneDate";
		dbCommand.Parameters["@ladTwentyTwoDate"].SourceColumn = "LAD_TwentyTwoDate";
		dbCommand.Parameters["@ladTwentyThreeDate"].SourceColumn = "LAD_TwentyThreeDate";
		dbCommand.Parameters["@ladTwentyFourDate"].SourceColumn = "LAD_TwentyFourDate";
		dbCommand.Parameters["@ladTwentyFiveDate"].SourceColumn = "LAD_TwentyFiveDate";
		dbCommand.Parameters["@ladTwentySixDate"].SourceColumn = "LAD_TwentySixDate";
		dbCommand.Parameters["@ladTwentySevenDate"].SourceColumn = "LAD_TwentySevenDate";
		dbCommand.Parameters["@ladTwentyEightDate"].SourceColumn = "LAD_TwentyEightDate";
		dbCommand.Parameters["@ladTwentyNineDate"].SourceColumn = "LAD_TwentyNineDate";
		dbCommand.Parameters["@ladThirtyDate"].SourceColumn = "LAD_ThirtyDate";
		dbCommand.Parameters["@ladThirtyOneDate"].SourceColumn = "LAD_ThirtyOneDate";
		dbCommand.Parameters["@ladAttendanceRemark"].SourceColumn = "LAD_AttendanceRemark";
		dbCommand.Parameters["@ladAttendanceBy"].SourceColumn = "LAD_AttendanceBy";
		dbCommand.Parameters["@ladDate"].SourceColumn = "LAD_Date";
		dbCommand.Parameters["@ladStatus"].SourceColumn = "LAD_Status";
		
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
	public static void Delete(System.Int64? ladAttendancedId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladAttendancedId);
		
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
	public static void Delete(System.Int64? ladAttendancedId)
	{
		Delete(
		ladAttendancedId);
	}
	
	/// <summary>
	/// Delete current TMSLibrarianAttendanceDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LADAttendancedId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LADAttendancedId = null;
	}
	
	/// <summary>
	/// Delete current TMSLibrarianAttendanceDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrarianAttendanceDetails[] Search(System.Int64? ladAttendancedId, System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ladAttendancedId, ladLibraryManagerId, ladLibrarianId, ladMonth, ladYear, ladOneDate, ladTwoDate, ladThreeDate, ladFourDate, ladFiveDate, ladSixDate, ladSevenDate, ladEightDate, ladNineDate, ladTenDate, ladElevenDate, ladTewelDate, ladThirteenDate, ladFourteenDate, ladFifteenDate, ladSixteenDate, ladSeventeenDate, ladEighteenDate, ladNineteenDate, ladTwentyDate, ladTwentyOneDate, ladTwentyTwoDate, ladTwentyThreeDate, ladTwentyFourDate, ladTwentyFiveDate, ladTwentySixDate, ladTwentySevenDate, ladTwentyEightDate, ladTwentyNineDate, ladThirtyDate, ladThirtyOneDate, ladAttendanceRemark, ladAttendanceBy, ladDate, ladStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLibrarianAttendanceDetails.MapFrom(ds);
	}
	
	
	public static TMSLibrarianAttendanceDetails[] Search(TMSLibrarianAttendanceDetails searchObject)
	{
		return Search ( searchObject.LADAttendancedId, searchObject.LADLibraryManagerId, searchObject.LADLibrarianId, searchObject.LADMonth, searchObject.LADYear, searchObject.LADOneDate, searchObject.LADTwoDate, searchObject.LADThreeDate, searchObject.LADFourDate, searchObject.LADFiveDate, searchObject.LADSixDate, searchObject.LADSevenDate, searchObject.LADEightDate, searchObject.LADNineDate, searchObject.LADTenDate, searchObject.LADElevenDate, searchObject.LADTewelDate, searchObject.LADThirteenDate, searchObject.LADFourteenDate, searchObject.LADFifteenDate, searchObject.LADSixteenDate, searchObject.LADSeventeenDate, searchObject.LADEighteenDate, searchObject.LADNineteenDate, searchObject.LADTwentyDate, searchObject.LADTwentyOneDate, searchObject.LADTwentyTwoDate, searchObject.LADTwentyThreeDate, searchObject.LADTwentyFourDate, searchObject.LADTwentyFiveDate, searchObject.LADTwentySixDate, searchObject.LADTwentySevenDate, searchObject.LADTwentyEightDate, searchObject.LADTwentyNineDate, searchObject.LADThirtyDate, searchObject.LADThirtyOneDate, searchObject.LADAttendanceRemark, searchObject.LADAttendanceBy, searchObject.LADDate, searchObject.LADStatus);
	}
	
	/// <summary>
	/// Returns all TMSLibrarianAttendanceDetails objects.
	/// </summary>
	/// <returns>List of all TMSLibrarianAttendanceDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLibrarianAttendanceDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

