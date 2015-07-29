/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/28/2012 3:07:55 PM                                    */
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
public partial class TMSAttendanceDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AttendanceDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sadAttendancedId;
	private System.Int64? _sadFacultyId;
	private System.Int64? _sadStudentId;
	private System.Int64? _sadSchoolId;
	private System.Int64? _sadSchoolSubId;
	private System.Int64? _sadSubjectId;
	private System.String _sadMonth;
	private System.String _sadYear;
	private System.String _sadOneDate;
	private System.String _sadTwoDate;
	private System.String _sadThreeDate;
	private System.String _sadFourDate;
	private System.String _sadFiveDate;
	private System.String _sadSixDate;
	private System.String _sadSevenDate;
	private System.String _sadEightDate;
	private System.String _sadNineDate;
	private System.String _sadTenDate;
	private System.String _sadElevenDate;
	private System.String _sadTewelDate;
	private System.String _sadThirteenDate;
	private System.String _sadFourteenDate;
	private System.String _sadFifteenDate;
	private System.String _sadSixteenDate;
	private System.String _sadSeventeenDate;
	private System.String _sadEighteenDate;
	private System.String _sadNineteenDate;
	private System.String _sadTwentyDate;
	private System.String _sadTwentyOneDate;
	private System.String _sadTwentyTwoDate;
	private System.String _sadTwentyThreeDate;
	private System.String _sadTwentyFourDate;
	private System.String _sadTwentyFiveDate;
	private System.String _sadTwentySixDate;
	private System.String _sadTwentySevenDate;
	private System.String _sadTwentyEightDate;
	private System.String _sadTwentyNineDate;
	private System.String _sadThirtyDate;
	private System.String _sadThirtyOneDate;
	private System.String _sadAttendanceRemark;
	private System.Int64? _sadAttendanceBy;
	private System.DateTime? _sadDate;
	private System.Int32? _sadStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SADAttendancedId
	{
		get
		{
			return _sadAttendancedId;
		}
		set
		{
			_sadAttendancedId = value;
		}
	}
	
	public System.Int64? SADFacultyId
	{
		get
		{
			return _sadFacultyId;
		}
		set
		{
			_sadFacultyId = value;
		}
	}
	
	public System.Int64? SADStudentId
	{
		get
		{
			return _sadStudentId;
		}
		set
		{
			_sadStudentId = value;
		}
	}
	
	public System.Int64? SADSchoolId
	{
		get
		{
			return _sadSchoolId;
		}
		set
		{
			_sadSchoolId = value;
		}
	}
	
	public System.Int64? SADSchoolSubId
	{
		get
		{
			return _sadSchoolSubId;
		}
		set
		{
			_sadSchoolSubId = value;
		}
	}
	
	public System.Int64? SADSubjectId
	{
		get
		{
			return _sadSubjectId;
		}
		set
		{
			_sadSubjectId = value;
		}
	}
	
	public System.String SADMonth
	{
		get
		{
			return _sadMonth;
		}
		set
		{
			_sadMonth = value;
		}
	}
	
	public System.String SADYear
	{
		get
		{
			return _sadYear;
		}
		set
		{
			_sadYear = value;
		}
	}
	
	public System.String SADOneDate
	{
		get
		{
			return _sadOneDate;
		}
		set
		{
			_sadOneDate = value;
		}
	}
	
	public System.String SADTwoDate
	{
		get
		{
			return _sadTwoDate;
		}
		set
		{
			_sadTwoDate = value;
		}
	}
	
	public System.String SADThreeDate
	{
		get
		{
			return _sadThreeDate;
		}
		set
		{
			_sadThreeDate = value;
		}
	}
	
	public System.String SADFourDate
	{
		get
		{
			return _sadFourDate;
		}
		set
		{
			_sadFourDate = value;
		}
	}
	
	public System.String SADFiveDate
	{
		get
		{
			return _sadFiveDate;
		}
		set
		{
			_sadFiveDate = value;
		}
	}
	
	public System.String SADSixDate
	{
		get
		{
			return _sadSixDate;
		}
		set
		{
			_sadSixDate = value;
		}
	}
	
	public System.String SADSevenDate
	{
		get
		{
			return _sadSevenDate;
		}
		set
		{
			_sadSevenDate = value;
		}
	}
	
	public System.String SADEightDate
	{
		get
		{
			return _sadEightDate;
		}
		set
		{
			_sadEightDate = value;
		}
	}
	
	public System.String SADNineDate
	{
		get
		{
			return _sadNineDate;
		}
		set
		{
			_sadNineDate = value;
		}
	}
	
	public System.String SADTenDate
	{
		get
		{
			return _sadTenDate;
		}
		set
		{
			_sadTenDate = value;
		}
	}
	
	public System.String SADElevenDate
	{
		get
		{
			return _sadElevenDate;
		}
		set
		{
			_sadElevenDate = value;
		}
	}
	
	public System.String SADTewelDate
	{
		get
		{
			return _sadTewelDate;
		}
		set
		{
			_sadTewelDate = value;
		}
	}
	
	public System.String SADThirteenDate
	{
		get
		{
			return _sadThirteenDate;
		}
		set
		{
			_sadThirteenDate = value;
		}
	}
	
	public System.String SADFourteenDate
	{
		get
		{
			return _sadFourteenDate;
		}
		set
		{
			_sadFourteenDate = value;
		}
	}
	
	public System.String SADFifteenDate
	{
		get
		{
			return _sadFifteenDate;
		}
		set
		{
			_sadFifteenDate = value;
		}
	}
	
	public System.String SADSixteenDate
	{
		get
		{
			return _sadSixteenDate;
		}
		set
		{
			_sadSixteenDate = value;
		}
	}
	
	public System.String SADSeventeenDate
	{
		get
		{
			return _sadSeventeenDate;
		}
		set
		{
			_sadSeventeenDate = value;
		}
	}
	
	public System.String SADEighteenDate
	{
		get
		{
			return _sadEighteenDate;
		}
		set
		{
			_sadEighteenDate = value;
		}
	}
	
	public System.String SADNineteenDate
	{
		get
		{
			return _sadNineteenDate;
		}
		set
		{
			_sadNineteenDate = value;
		}
	}
	
	public System.String SADTwentyDate
	{
		get
		{
			return _sadTwentyDate;
		}
		set
		{
			_sadTwentyDate = value;
		}
	}
	
	public System.String SADTwentyOneDate
	{
		get
		{
			return _sadTwentyOneDate;
		}
		set
		{
			_sadTwentyOneDate = value;
		}
	}
	
	public System.String SADTwentyTwoDate
	{
		get
		{
			return _sadTwentyTwoDate;
		}
		set
		{
			_sadTwentyTwoDate = value;
		}
	}
	
	public System.String SADTwentyThreeDate
	{
		get
		{
			return _sadTwentyThreeDate;
		}
		set
		{
			_sadTwentyThreeDate = value;
		}
	}
	
	public System.String SADTwentyFourDate
	{
		get
		{
			return _sadTwentyFourDate;
		}
		set
		{
			_sadTwentyFourDate = value;
		}
	}
	
	public System.String SADTwentyFiveDate
	{
		get
		{
			return _sadTwentyFiveDate;
		}
		set
		{
			_sadTwentyFiveDate = value;
		}
	}
	
	public System.String SADTwentySixDate
	{
		get
		{
			return _sadTwentySixDate;
		}
		set
		{
			_sadTwentySixDate = value;
		}
	}
	
	public System.String SADTwentySevenDate
	{
		get
		{
			return _sadTwentySevenDate;
		}
		set
		{
			_sadTwentySevenDate = value;
		}
	}
	
	public System.String SADTwentyEightDate
	{
		get
		{
			return _sadTwentyEightDate;
		}
		set
		{
			_sadTwentyEightDate = value;
		}
	}
	
	public System.String SADTwentyNineDate
	{
		get
		{
			return _sadTwentyNineDate;
		}
		set
		{
			_sadTwentyNineDate = value;
		}
	}
	
	public System.String SADThirtyDate
	{
		get
		{
			return _sadThirtyDate;
		}
		set
		{
			_sadThirtyDate = value;
		}
	}
	
	public System.String SADThirtyOneDate
	{
		get
		{
			return _sadThirtyOneDate;
		}
		set
		{
			_sadThirtyOneDate = value;
		}
	}
	
	public System.String SADAttendanceRemark
	{
		get
		{
			return _sadAttendanceRemark;
		}
		set
		{
			_sadAttendanceRemark = value;
		}
	}
	
	public System.Int64? SADAttendanceBy
	{
		get
		{
			return _sadAttendanceBy;
		}
		set
		{
			_sadAttendanceBy = value;
		}
	}
	
	public System.DateTime? SADDate
	{
		get
		{
			return _sadDate;
		}
		set
		{
			_sadDate = value;
		}
	}
	
	public System.Int32? SADStatus
	{
		get
		{
			return _sadStatus;
		}
		set
		{
			_sadStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SAD_AttendancedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_OneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwoDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_ThreeDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_FourDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_FiveDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SixDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_EightDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_NineDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_ElevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TewelDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_ThirteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_FourteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_FifteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SixteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_SeventeenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_EighteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_NineteenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyOneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyTwoDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyThreeDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyFourDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyFiveDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentySixDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentySevenDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyEightDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_TwentyNineDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_ThirtyDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_ThirtyOneDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_AttendanceRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_AttendanceBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SADAttendancedId == null)
		dr["SAD_AttendancedId"] = DBNull.Value;
		else
		dr["SAD_AttendancedId"] = SADAttendancedId;
		
		if (SADFacultyId == null)
		dr["SAD_FacultyId"] = DBNull.Value;
		else
		dr["SAD_FacultyId"] = SADFacultyId;
		
		if (SADStudentId == null)
		dr["SAD_StudentId"] = DBNull.Value;
		else
		dr["SAD_StudentId"] = SADStudentId;
		
		if (SADSchoolId == null)
		dr["SAD_SchoolId"] = DBNull.Value;
		else
		dr["SAD_SchoolId"] = SADSchoolId;
		
		if (SADSchoolSubId == null)
		dr["SAD_SchoolSubId"] = DBNull.Value;
		else
		dr["SAD_SchoolSubId"] = SADSchoolSubId;
		
		if (SADSubjectId == null)
		dr["SAD_SubjectId"] = DBNull.Value;
		else
		dr["SAD_SubjectId"] = SADSubjectId;
		
		if (SADMonth == null)
		dr["SAD_Month"] = DBNull.Value;
		else
		dr["SAD_Month"] = SADMonth;
		
		if (SADYear == null)
		dr["SAD_Year"] = DBNull.Value;
		else
		dr["SAD_Year"] = SADYear;
		
		if (SADOneDate == null)
		dr["SAD_OneDate"] = DBNull.Value;
		else
		dr["SAD_OneDate"] = SADOneDate;
		
		if (SADTwoDate == null)
		dr["SAD_TwoDate"] = DBNull.Value;
		else
		dr["SAD_TwoDate"] = SADTwoDate;
		
		if (SADThreeDate == null)
		dr["SAD_ThreeDate"] = DBNull.Value;
		else
		dr["SAD_ThreeDate"] = SADThreeDate;
		
		if (SADFourDate == null)
		dr["SAD_FourDate"] = DBNull.Value;
		else
		dr["SAD_FourDate"] = SADFourDate;
		
		if (SADFiveDate == null)
		dr["SAD_FiveDate"] = DBNull.Value;
		else
		dr["SAD_FiveDate"] = SADFiveDate;
		
		if (SADSixDate == null)
		dr["SAD_SixDate"] = DBNull.Value;
		else
		dr["SAD_SixDate"] = SADSixDate;
		
		if (SADSevenDate == null)
		dr["SAD_SevenDate"] = DBNull.Value;
		else
		dr["SAD_SevenDate"] = SADSevenDate;
		
		if (SADEightDate == null)
		dr["SAD_EightDate"] = DBNull.Value;
		else
		dr["SAD_EightDate"] = SADEightDate;
		
		if (SADNineDate == null)
		dr["SAD_NineDate"] = DBNull.Value;
		else
		dr["SAD_NineDate"] = SADNineDate;
		
		if (SADTenDate == null)
		dr["SAD_TenDate"] = DBNull.Value;
		else
		dr["SAD_TenDate"] = SADTenDate;
		
		if (SADElevenDate == null)
		dr["SAD_ElevenDate"] = DBNull.Value;
		else
		dr["SAD_ElevenDate"] = SADElevenDate;
		
		if (SADTewelDate == null)
		dr["SAD_TewelDate"] = DBNull.Value;
		else
		dr["SAD_TewelDate"] = SADTewelDate;
		
		if (SADThirteenDate == null)
		dr["SAD_ThirteenDate"] = DBNull.Value;
		else
		dr["SAD_ThirteenDate"] = SADThirteenDate;
		
		if (SADFourteenDate == null)
		dr["SAD_FourteenDate"] = DBNull.Value;
		else
		dr["SAD_FourteenDate"] = SADFourteenDate;
		
		if (SADFifteenDate == null)
		dr["SAD_FifteenDate"] = DBNull.Value;
		else
		dr["SAD_FifteenDate"] = SADFifteenDate;
		
		if (SADSixteenDate == null)
		dr["SAD_SixteenDate"] = DBNull.Value;
		else
		dr["SAD_SixteenDate"] = SADSixteenDate;
		
		if (SADSeventeenDate == null)
		dr["SAD_SeventeenDate"] = DBNull.Value;
		else
		dr["SAD_SeventeenDate"] = SADSeventeenDate;
		
		if (SADEighteenDate == null)
		dr["SAD_EighteenDate"] = DBNull.Value;
		else
		dr["SAD_EighteenDate"] = SADEighteenDate;
		
		if (SADNineteenDate == null)
		dr["SAD_NineteenDate"] = DBNull.Value;
		else
		dr["SAD_NineteenDate"] = SADNineteenDate;
		
		if (SADTwentyDate == null)
		dr["SAD_TwentyDate"] = DBNull.Value;
		else
		dr["SAD_TwentyDate"] = SADTwentyDate;
		
		if (SADTwentyOneDate == null)
		dr["SAD_TwentyOneDate"] = DBNull.Value;
		else
		dr["SAD_TwentyOneDate"] = SADTwentyOneDate;
		
		if (SADTwentyTwoDate == null)
		dr["SAD_TwentyTwoDate"] = DBNull.Value;
		else
		dr["SAD_TwentyTwoDate"] = SADTwentyTwoDate;
		
		if (SADTwentyThreeDate == null)
		dr["SAD_TwentyThreeDate"] = DBNull.Value;
		else
		dr["SAD_TwentyThreeDate"] = SADTwentyThreeDate;
		
		if (SADTwentyFourDate == null)
		dr["SAD_TwentyFourDate"] = DBNull.Value;
		else
		dr["SAD_TwentyFourDate"] = SADTwentyFourDate;
		
		if (SADTwentyFiveDate == null)
		dr["SAD_TwentyFiveDate"] = DBNull.Value;
		else
		dr["SAD_TwentyFiveDate"] = SADTwentyFiveDate;
		
		if (SADTwentySixDate == null)
		dr["SAD_TwentySixDate"] = DBNull.Value;
		else
		dr["SAD_TwentySixDate"] = SADTwentySixDate;
		
		if (SADTwentySevenDate == null)
		dr["SAD_TwentySevenDate"] = DBNull.Value;
		else
		dr["SAD_TwentySevenDate"] = SADTwentySevenDate;
		
		if (SADTwentyEightDate == null)
		dr["SAD_TwentyEightDate"] = DBNull.Value;
		else
		dr["SAD_TwentyEightDate"] = SADTwentyEightDate;
		
		if (SADTwentyNineDate == null)
		dr["SAD_TwentyNineDate"] = DBNull.Value;
		else
		dr["SAD_TwentyNineDate"] = SADTwentyNineDate;
		
		if (SADThirtyDate == null)
		dr["SAD_ThirtyDate"] = DBNull.Value;
		else
		dr["SAD_ThirtyDate"] = SADThirtyDate;
		
		if (SADThirtyOneDate == null)
		dr["SAD_ThirtyOneDate"] = DBNull.Value;
		else
		dr["SAD_ThirtyOneDate"] = SADThirtyOneDate;
		
		if (SADAttendanceRemark == null)
		dr["SAD_AttendanceRemark"] = DBNull.Value;
		else
		dr["SAD_AttendanceRemark"] = SADAttendanceRemark;
		
		if (SADAttendanceBy == null)
		dr["SAD_AttendanceBy"] = DBNull.Value;
		else
		dr["SAD_AttendanceBy"] = SADAttendanceBy;
		
		if (SADDate == null)
		dr["SAD_Date"] = DBNull.Value;
		else
		dr["SAD_Date"] = SADDate;
		
		if (SADStatus == null)
		dr["SAD_Status"] = DBNull.Value;
		else
		dr["SAD_Status"] = SADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SADAttendancedId = dr["SAD_AttendancedId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_AttendancedId"]) : SADAttendancedId = null;
		SADFacultyId = dr["SAD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_FacultyId"]) : SADFacultyId = null;
		SADStudentId = dr["SAD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_StudentId"]) : SADStudentId = null;
		SADSchoolId = dr["SAD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_SchoolId"]) : SADSchoolId = null;
		SADSchoolSubId = dr["SAD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_SchoolSubId"]) : SADSchoolSubId = null;
		SADSubjectId = dr["SAD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SAD_SubjectId"]) : SADSubjectId = null;
		SADMonth = dr["SAD_Month"] != DBNull.Value ? Convert.ToString(dr["SAD_Month"]) : SADMonth = null;
		SADYear = dr["SAD_Year"] != DBNull.Value ? Convert.ToString(dr["SAD_Year"]) : SADYear = null;
		SADOneDate = dr["SAD_OneDate"] != DBNull.Value ? Convert.ToString(dr["SAD_OneDate"]) : SADOneDate = null;
		SADTwoDate = dr["SAD_TwoDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwoDate"]) : SADTwoDate = null;
		SADThreeDate = dr["SAD_ThreeDate"] != DBNull.Value ? Convert.ToString(dr["SAD_ThreeDate"]) : SADThreeDate = null;
		SADFourDate = dr["SAD_FourDate"] != DBNull.Value ? Convert.ToString(dr["SAD_FourDate"]) : SADFourDate = null;
		SADFiveDate = dr["SAD_FiveDate"] != DBNull.Value ? Convert.ToString(dr["SAD_FiveDate"]) : SADFiveDate = null;
		SADSixDate = dr["SAD_SixDate"] != DBNull.Value ? Convert.ToString(dr["SAD_SixDate"]) : SADSixDate = null;
		SADSevenDate = dr["SAD_SevenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_SevenDate"]) : SADSevenDate = null;
		SADEightDate = dr["SAD_EightDate"] != DBNull.Value ? Convert.ToString(dr["SAD_EightDate"]) : SADEightDate = null;
		SADNineDate = dr["SAD_NineDate"] != DBNull.Value ? Convert.ToString(dr["SAD_NineDate"]) : SADNineDate = null;
		SADTenDate = dr["SAD_TenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TenDate"]) : SADTenDate = null;
		SADElevenDate = dr["SAD_ElevenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_ElevenDate"]) : SADElevenDate = null;
		SADTewelDate = dr["SAD_TewelDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TewelDate"]) : SADTewelDate = null;
		SADThirteenDate = dr["SAD_ThirteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_ThirteenDate"]) : SADThirteenDate = null;
		SADFourteenDate = dr["SAD_FourteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_FourteenDate"]) : SADFourteenDate = null;
		SADFifteenDate = dr["SAD_FifteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_FifteenDate"]) : SADFifteenDate = null;
		SADSixteenDate = dr["SAD_SixteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_SixteenDate"]) : SADSixteenDate = null;
		SADSeventeenDate = dr["SAD_SeventeenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_SeventeenDate"]) : SADSeventeenDate = null;
		SADEighteenDate = dr["SAD_EighteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_EighteenDate"]) : SADEighteenDate = null;
		SADNineteenDate = dr["SAD_NineteenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_NineteenDate"]) : SADNineteenDate = null;
		SADTwentyDate = dr["SAD_TwentyDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyDate"]) : SADTwentyDate = null;
		SADTwentyOneDate = dr["SAD_TwentyOneDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyOneDate"]) : SADTwentyOneDate = null;
		SADTwentyTwoDate = dr["SAD_TwentyTwoDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyTwoDate"]) : SADTwentyTwoDate = null;
		SADTwentyThreeDate = dr["SAD_TwentyThreeDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyThreeDate"]) : SADTwentyThreeDate = null;
		SADTwentyFourDate = dr["SAD_TwentyFourDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyFourDate"]) : SADTwentyFourDate = null;
		SADTwentyFiveDate = dr["SAD_TwentyFiveDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyFiveDate"]) : SADTwentyFiveDate = null;
		SADTwentySixDate = dr["SAD_TwentySixDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentySixDate"]) : SADTwentySixDate = null;
		SADTwentySevenDate = dr["SAD_TwentySevenDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentySevenDate"]) : SADTwentySevenDate = null;
		SADTwentyEightDate = dr["SAD_TwentyEightDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyEightDate"]) : SADTwentyEightDate = null;
		SADTwentyNineDate = dr["SAD_TwentyNineDate"] != DBNull.Value ? Convert.ToString(dr["SAD_TwentyNineDate"]) : SADTwentyNineDate = null;
		SADThirtyDate = dr["SAD_ThirtyDate"] != DBNull.Value ? Convert.ToString(dr["SAD_ThirtyDate"]) : SADThirtyDate = null;
		SADThirtyOneDate = dr["SAD_ThirtyOneDate"] != DBNull.Value ? Convert.ToString(dr["SAD_ThirtyOneDate"]) : SADThirtyOneDate = null;
		SADAttendanceRemark = dr["SAD_AttendanceRemark"] != DBNull.Value ? Convert.ToString(dr["SAD_AttendanceRemark"]) : SADAttendanceRemark = null;
		SADAttendanceBy = dr["SAD_AttendanceBy"] != DBNull.Value ? Convert.ToInt64(dr["SAD_AttendanceBy"]) : SADAttendanceBy = null;
		SADDate = dr["SAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SAD_Date"]) : SADDate = null;
		SADStatus = dr["SAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SAD_Status"]) : SADStatus = null;
	}
	
	public static TMSAttendanceDetails[] MapFrom(DataSet ds)
	{
		List<TMSAttendanceDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAttendanceDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AttendanceDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AttendanceDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAttendanceDetails instance = new TMSAttendanceDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAttendanceDetails Get(System.Int64 sadAttendancedId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAttendanceDetails instance;
		
		
		instance = new TMSAttendanceDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sadAttendancedId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAttendanceDetails ID:" + sadAttendancedId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sadFacultyId, sadStudentId, sadSchoolId, sadSchoolSubId, sadSubjectId, sadMonth, sadYear, sadOneDate, sadTwoDate, sadThreeDate, sadFourDate, sadFiveDate, sadSixDate, sadSevenDate, sadEightDate, sadNineDate, sadTenDate, sadElevenDate, sadTewelDate, sadThirteenDate, sadFourteenDate, sadFifteenDate, sadSixteenDate, sadSeventeenDate, sadEighteenDate, sadNineteenDate, sadTwentyDate, sadTwentyOneDate, sadTwentyTwoDate, sadTwentyThreeDate, sadTwentyFourDate, sadTwentyFiveDate, sadTwentySixDate, sadTwentySevenDate, sadTwentyEightDate, sadTwentyNineDate, sadThirtyDate, sadThirtyOneDate, sadAttendanceRemark, sadAttendanceBy, sadDate, sadStatus);
		
		if (transaction == null)
		this.SADAttendancedId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SADAttendancedId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus)
	{
		Insert(sadFacultyId, sadStudentId, sadSchoolId, sadSchoolSubId, sadSubjectId, sadMonth, sadYear, sadOneDate, sadTwoDate, sadThreeDate, sadFourDate, sadFiveDate, sadSixDate, sadSevenDate, sadEightDate, sadNineDate, sadTenDate, sadElevenDate, sadTewelDate, sadThirteenDate, sadFourteenDate, sadFifteenDate, sadSixteenDate, sadSeventeenDate, sadEighteenDate, sadNineteenDate, sadTwentyDate, sadTwentyOneDate, sadTwentyTwoDate, sadTwentyThreeDate, sadTwentyFourDate, sadTwentyFiveDate, sadTwentySixDate, sadTwentySevenDate, sadTwentyEightDate, sadTwentyNineDate, sadThirtyDate, sadThirtyOneDate, sadAttendanceRemark, sadAttendanceBy, sadDate, sadStatus, null);
	}
	/// <summary>
	/// Insert current TMSAttendanceDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SADFacultyId, SADStudentId, SADSchoolId, SADSchoolSubId, SADSubjectId, SADMonth, SADYear, SADOneDate, SADTwoDate, SADThreeDate, SADFourDate, SADFiveDate, SADSixDate, SADSevenDate, SADEightDate, SADNineDate, SADTenDate, SADElevenDate, SADTewelDate, SADThirteenDate, SADFourteenDate, SADFifteenDate, SADSixteenDate, SADSeventeenDate, SADEighteenDate, SADNineteenDate, SADTwentyDate, SADTwentyOneDate, SADTwentyTwoDate, SADTwentyThreeDate, SADTwentyFourDate, SADTwentyFiveDate, SADTwentySixDate, SADTwentySevenDate, SADTwentyEightDate, SADTwentyNineDate, SADThirtyDate, SADThirtyOneDate, SADAttendanceRemark, SADAttendanceBy, SADDate, SADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAttendanceDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sadAttendancedId, System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sadAttendancedId"].Value = sadAttendancedId;
		dbCommand.Parameters["@sadFacultyId"].Value = sadFacultyId;
		dbCommand.Parameters["@sadStudentId"].Value = sadStudentId;
		dbCommand.Parameters["@sadSchoolId"].Value = sadSchoolId;
		dbCommand.Parameters["@sadSchoolSubId"].Value = sadSchoolSubId;
		dbCommand.Parameters["@sadSubjectId"].Value = sadSubjectId;
		dbCommand.Parameters["@sadMonth"].Value = sadMonth;
		dbCommand.Parameters["@sadYear"].Value = sadYear;
		dbCommand.Parameters["@sadOneDate"].Value = sadOneDate;
		dbCommand.Parameters["@sadTwoDate"].Value = sadTwoDate;
		dbCommand.Parameters["@sadThreeDate"].Value = sadThreeDate;
		dbCommand.Parameters["@sadFourDate"].Value = sadFourDate;
		dbCommand.Parameters["@sadFiveDate"].Value = sadFiveDate;
		dbCommand.Parameters["@sadSixDate"].Value = sadSixDate;
		dbCommand.Parameters["@sadSevenDate"].Value = sadSevenDate;
		dbCommand.Parameters["@sadEightDate"].Value = sadEightDate;
		dbCommand.Parameters["@sadNineDate"].Value = sadNineDate;
		dbCommand.Parameters["@sadTenDate"].Value = sadTenDate;
		dbCommand.Parameters["@sadElevenDate"].Value = sadElevenDate;
		dbCommand.Parameters["@sadTewelDate"].Value = sadTewelDate;
		dbCommand.Parameters["@sadThirteenDate"].Value = sadThirteenDate;
		dbCommand.Parameters["@sadFourteenDate"].Value = sadFourteenDate;
		dbCommand.Parameters["@sadFifteenDate"].Value = sadFifteenDate;
		dbCommand.Parameters["@sadSixteenDate"].Value = sadSixteenDate;
		dbCommand.Parameters["@sadSeventeenDate"].Value = sadSeventeenDate;
		dbCommand.Parameters["@sadEighteenDate"].Value = sadEighteenDate;
		dbCommand.Parameters["@sadNineteenDate"].Value = sadNineteenDate;
		dbCommand.Parameters["@sadTwentyDate"].Value = sadTwentyDate;
		dbCommand.Parameters["@sadTwentyOneDate"].Value = sadTwentyOneDate;
		dbCommand.Parameters["@sadTwentyTwoDate"].Value = sadTwentyTwoDate;
		dbCommand.Parameters["@sadTwentyThreeDate"].Value = sadTwentyThreeDate;
		dbCommand.Parameters["@sadTwentyFourDate"].Value = sadTwentyFourDate;
		dbCommand.Parameters["@sadTwentyFiveDate"].Value = sadTwentyFiveDate;
		dbCommand.Parameters["@sadTwentySixDate"].Value = sadTwentySixDate;
		dbCommand.Parameters["@sadTwentySevenDate"].Value = sadTwentySevenDate;
		dbCommand.Parameters["@sadTwentyEightDate"].Value = sadTwentyEightDate;
		dbCommand.Parameters["@sadTwentyNineDate"].Value = sadTwentyNineDate;
		dbCommand.Parameters["@sadThirtyDate"].Value = sadThirtyDate;
		dbCommand.Parameters["@sadThirtyOneDate"].Value = sadThirtyOneDate;
		dbCommand.Parameters["@sadAttendanceRemark"].Value = sadAttendanceRemark;
		dbCommand.Parameters["@sadAttendanceBy"].Value = sadAttendanceBy;
		dbCommand.Parameters["@sadDate"].Value = sadDate;
		dbCommand.Parameters["@sadStatus"].Value = sadStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sadAttendancedId, System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus)
	{
		Update(sadAttendancedId, sadFacultyId, sadStudentId, sadSchoolId, sadSchoolSubId, sadSubjectId, sadMonth, sadYear, sadOneDate, sadTwoDate, sadThreeDate, sadFourDate, sadFiveDate, sadSixDate, sadSevenDate, sadEightDate, sadNineDate, sadTenDate, sadElevenDate, sadTewelDate, sadThirteenDate, sadFourteenDate, sadFifteenDate, sadSixteenDate, sadSeventeenDate, sadEighteenDate, sadNineteenDate, sadTwentyDate, sadTwentyOneDate, sadTwentyTwoDate, sadTwentyThreeDate, sadTwentyFourDate, sadTwentyFiveDate, sadTwentySixDate, sadTwentySevenDate, sadTwentyEightDate, sadTwentyNineDate, sadThirtyDate, sadThirtyOneDate, sadAttendanceRemark, sadAttendanceBy, sadDate, sadStatus, null);
	}
	
	public static void Update(TMSAttendanceDetails tMSAttendanceDetails)
	{
		tMSAttendanceDetails.Update();
	}
	
	public static void Update(TMSAttendanceDetails tMSAttendanceDetails, DbTransaction transaction)
	{
		tMSAttendanceDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAttendanceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sadAttendancedId"].SourceColumn = "SAD_AttendancedId";
		dbCommand.Parameters["@sadFacultyId"].SourceColumn = "SAD_FacultyId";
		dbCommand.Parameters["@sadStudentId"].SourceColumn = "SAD_StudentId";
		dbCommand.Parameters["@sadSchoolId"].SourceColumn = "SAD_SchoolId";
		dbCommand.Parameters["@sadSchoolSubId"].SourceColumn = "SAD_SchoolSubId";
		dbCommand.Parameters["@sadSubjectId"].SourceColumn = "SAD_SubjectId";
		dbCommand.Parameters["@sadMonth"].SourceColumn = "SAD_Month";
		dbCommand.Parameters["@sadYear"].SourceColumn = "SAD_Year";
		dbCommand.Parameters["@sadOneDate"].SourceColumn = "SAD_OneDate";
		dbCommand.Parameters["@sadTwoDate"].SourceColumn = "SAD_TwoDate";
		dbCommand.Parameters["@sadThreeDate"].SourceColumn = "SAD_ThreeDate";
		dbCommand.Parameters["@sadFourDate"].SourceColumn = "SAD_FourDate";
		dbCommand.Parameters["@sadFiveDate"].SourceColumn = "SAD_FiveDate";
		dbCommand.Parameters["@sadSixDate"].SourceColumn = "SAD_SixDate";
		dbCommand.Parameters["@sadSevenDate"].SourceColumn = "SAD_SevenDate";
		dbCommand.Parameters["@sadEightDate"].SourceColumn = "SAD_EightDate";
		dbCommand.Parameters["@sadNineDate"].SourceColumn = "SAD_NineDate";
		dbCommand.Parameters["@sadTenDate"].SourceColumn = "SAD_TenDate";
		dbCommand.Parameters["@sadElevenDate"].SourceColumn = "SAD_ElevenDate";
		dbCommand.Parameters["@sadTewelDate"].SourceColumn = "SAD_TewelDate";
		dbCommand.Parameters["@sadThirteenDate"].SourceColumn = "SAD_ThirteenDate";
		dbCommand.Parameters["@sadFourteenDate"].SourceColumn = "SAD_FourteenDate";
		dbCommand.Parameters["@sadFifteenDate"].SourceColumn = "SAD_FifteenDate";
		dbCommand.Parameters["@sadSixteenDate"].SourceColumn = "SAD_SixteenDate";
		dbCommand.Parameters["@sadSeventeenDate"].SourceColumn = "SAD_SeventeenDate";
		dbCommand.Parameters["@sadEighteenDate"].SourceColumn = "SAD_EighteenDate";
		dbCommand.Parameters["@sadNineteenDate"].SourceColumn = "SAD_NineteenDate";
		dbCommand.Parameters["@sadTwentyDate"].SourceColumn = "SAD_TwentyDate";
		dbCommand.Parameters["@sadTwentyOneDate"].SourceColumn = "SAD_TwentyOneDate";
		dbCommand.Parameters["@sadTwentyTwoDate"].SourceColumn = "SAD_TwentyTwoDate";
		dbCommand.Parameters["@sadTwentyThreeDate"].SourceColumn = "SAD_TwentyThreeDate";
		dbCommand.Parameters["@sadTwentyFourDate"].SourceColumn = "SAD_TwentyFourDate";
		dbCommand.Parameters["@sadTwentyFiveDate"].SourceColumn = "SAD_TwentyFiveDate";
		dbCommand.Parameters["@sadTwentySixDate"].SourceColumn = "SAD_TwentySixDate";
		dbCommand.Parameters["@sadTwentySevenDate"].SourceColumn = "SAD_TwentySevenDate";
		dbCommand.Parameters["@sadTwentyEightDate"].SourceColumn = "SAD_TwentyEightDate";
		dbCommand.Parameters["@sadTwentyNineDate"].SourceColumn = "SAD_TwentyNineDate";
		dbCommand.Parameters["@sadThirtyDate"].SourceColumn = "SAD_ThirtyDate";
		dbCommand.Parameters["@sadThirtyOneDate"].SourceColumn = "SAD_ThirtyOneDate";
		dbCommand.Parameters["@sadAttendanceRemark"].SourceColumn = "SAD_AttendanceRemark";
		dbCommand.Parameters["@sadAttendanceBy"].SourceColumn = "SAD_AttendanceBy";
		dbCommand.Parameters["@sadDate"].SourceColumn = "SAD_Date";
		dbCommand.Parameters["@sadStatus"].SourceColumn = "SAD_Status";
		
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
	public static void Delete(System.Int64? sadAttendancedId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sadAttendancedId);
		
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
	public static void Delete(System.Int64? sadAttendancedId)
	{
		Delete(
		sadAttendancedId);
	}
	
	/// <summary>
	/// Delete current TMSAttendanceDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SADAttendancedId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SADAttendancedId = null;
	}
	
	/// <summary>
	/// Delete current TMSAttendanceDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAttendanceDetails[] Search(System.Int64? sadAttendancedId, System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttendanceDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sadAttendancedId, sadFacultyId, sadStudentId, sadSchoolId, sadSchoolSubId, sadSubjectId, sadMonth, sadYear, sadOneDate, sadTwoDate, sadThreeDate, sadFourDate, sadFiveDate, sadSixDate, sadSevenDate, sadEightDate, sadNineDate, sadTenDate, sadElevenDate, sadTewelDate, sadThirteenDate, sadFourteenDate, sadFifteenDate, sadSixteenDate, sadSeventeenDate, sadEighteenDate, sadNineteenDate, sadTwentyDate, sadTwentyOneDate, sadTwentyTwoDate, sadTwentyThreeDate, sadTwentyFourDate, sadTwentyFiveDate, sadTwentySixDate, sadTwentySevenDate, sadTwentyEightDate, sadTwentyNineDate, sadThirtyDate, sadThirtyOneDate, sadAttendanceRemark, sadAttendanceBy, sadDate, sadStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAttendanceDetails.MapFrom(ds);
	}
	
	
	public static TMSAttendanceDetails[] Search(TMSAttendanceDetails searchObject)
	{
		return Search ( searchObject.SADAttendancedId, searchObject.SADFacultyId, searchObject.SADStudentId, searchObject.SADSchoolId, searchObject.SADSchoolSubId, searchObject.SADSubjectId, searchObject.SADMonth, searchObject.SADYear, searchObject.SADOneDate, searchObject.SADTwoDate, searchObject.SADThreeDate, searchObject.SADFourDate, searchObject.SADFiveDate, searchObject.SADSixDate, searchObject.SADSevenDate, searchObject.SADEightDate, searchObject.SADNineDate, searchObject.SADTenDate, searchObject.SADElevenDate, searchObject.SADTewelDate, searchObject.SADThirteenDate, searchObject.SADFourteenDate, searchObject.SADFifteenDate, searchObject.SADSixteenDate, searchObject.SADSeventeenDate, searchObject.SADEighteenDate, searchObject.SADNineteenDate, searchObject.SADTwentyDate, searchObject.SADTwentyOneDate, searchObject.SADTwentyTwoDate, searchObject.SADTwentyThreeDate, searchObject.SADTwentyFourDate, searchObject.SADTwentyFiveDate, searchObject.SADTwentySixDate, searchObject.SADTwentySevenDate, searchObject.SADTwentyEightDate, searchObject.SADTwentyNineDate, searchObject.SADThirtyDate, searchObject.SADThirtyOneDate, searchObject.SADAttendanceRemark, searchObject.SADAttendanceBy, searchObject.SADDate, searchObject.SADStatus);
	}
	
	/// <summary>
	/// Returns all TMSAttendanceDetails objects.
	/// </summary>
	/// <returns>List of all TMSAttendanceDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAttendanceDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

