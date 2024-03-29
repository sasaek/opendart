﻿using System;
using OpenDart.Models;
using OpenDart.OpenDartClient;
using Npgsql;

namespace OpenDartTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_OpenDart();
            // Test_PostgreSQL();
        }

        static void Test_OpenDart()
        {
            try
            {
                OpenDartClient client = new OpenDartClient();
                // OpenDartClient client = new OpenDartClient("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                // Open DART API Key(https://opendart.fss.or.kr/ 에서 발급받아야함)
                client.apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
                client.dummyDirectory = @"/home/lgh/project/dummy";

                //========================================================================
                // 1. 공시정보 테스트 (REQ1_XXX)
                //========================================================================
                // 1.1. 공시검색: 공시 유형별, 회사별, 날짜별 등 여러가지 조건으로 공시보고서 검색기능을 제공합니다.
                // ReqDisclosureSearch rds = new ReqDisclosureSearch();
                // ResDisclosureSearchResult result = client.REQ1_1_GET_DISCLOSURE_SEARCH(rds);

                // 1.2. 기업개황: 두산중공업(00159616)
                // ResCompanyInfo result = client.REQ1_2_GET_COMPANY_INFO("00159616", true);

                // 1.3. 공시서류원본파일: 20190401004781
                // 다운로드 파일 경로
                // string result = client.REQ1_3_GET_DOCUMENT_FILE("20190401004781");

                // 1.4. 고유번호(전체 기업 종목코드 파일 다운로드 및 설정)
                // ResCorpCodeResult result = client.REQ1_4_GET_CORPCODE_INFO();
                //========================================================================

                //========================================================================
                // 2. 사업보고서 주요정보 테스트 (REQ2_XXX)
                //========================================================================
                // 2.1. 증자(감자) 현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResIrdsSttusResult result = client.REQ2_1_GET_IRDS_STTUS_INFO("00126380", "2018", "11011");

                // 2.2. 배당에 관한 사항, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResAlotMatterResult result = client.REQ2_2_GET_ALOT_MATTER_INFO("00126380", "2018", "11011");

                // 2.3. 자기주식 취득 및 처분 현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResTesstkAcqsDspsSttusResult result = client.REQ2_3_GET_TESSTK_ACQS_DSPS_STTUS_INFO("00126380", "2018", "11011");

                // 2.4. 최대주주 현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResHyslrSttusResult result = client.REQ2_4_GET_HYSLR_STTUS_INFO("00126380", "2018", "11011");

                // 2.5. 최대주주 변동 현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResHyslrChgSttusResult result = client.REQ2_5_GET_HYSLR_CHG_STTUS_INFO("00126380", "2018", "11011");

                // 2.6. 소액주주현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResMrhlSttusResult result = client.REQ2_6_GET_MRHL_STTUS_INFO("00126380", "2018", "11011");

                // 2.7. 임원현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResExctvSttusResult result = client.REQ2_7_GET_EXCTV_STTUS_INFO("00126380", "2018", "11011");

                // 2.8. 직원현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResEmpSttusResult result = client.REQ2_8_GET_EMP_STTUS_INFO("00126380", "2018", "11011");

                // 2.9. 이사ㆍ감사의 개인별 보수 현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResHmvAuditIndvdlBySttusResult result = client.REQ2_9_GET_HMV_AUDIT_INDVDL_BY_STTUS_INFO("00126380", "2018", "11011");

                // 2.10. 이사ㆍ감사 전체의 보수현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResHmvAuditAllSttusResult result = client.REQ2_10_GET_HMV_AUDIT_ALL_STTUS_INFO("00126380", "2018", "11011");

                // 2.11. 개인별 보수지급 금액(5억이상 상위5인), corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResIndvdlByPayResult result = client.REQ2_11_GET_INDVDL_BY_PAY_INFO("00126380", "2018", "11011");

                // 2.12. 타법인 출자현황, corp_code=00126380&bsns_year=2018&reprt_code=11011
                // ResOtrCprInvstmntSttusResult result = client.REQ2_12_GET_OTR_CPR_INVSTMNT_STTUS_INFO("00126380", "2018", "11011");
                //========================================================================

                //========================================================================
                // 3. 상장기업 재무정보 테스트 (REQ3_XXX)
                //========================================================================
                // 3.1. 단일회사 주요계정, corp_code=00126380&bsns_year=2018&reprt_code=11011
                ResFnlttSinglAcntResult result = client.REQ3_1_GET_FNLTT_SINGL_ACNT_INFO("00126380", "2018", "11011");

                // 3.2. 다중회사 주요계정, corp_code=00356370,00334624&bsns_year=2018&reprt_code=11011
                // ResFnlttMultiAcntResult result = client.REQ3_2_GET_FNLTT_MULTI_ACNT_INFO("00356370,00334624", "2018", "11011");

                // 3.3. 재무제표 원본파일(XBRL), corp_code=00356370,00334624&bsns_year=2018&reprt_code=11011
                // 파일 다운로드 경로
                // string result = client.REQ3_3_GET_FNLTT_XBRL_INFO("20190401004781", "11011");

                // 3.4. 단일회사 전체 재무제표, corp_code=00126380&bsns_year=2018&reprt_code=11011&fs_div=OFS
                // ResFnlttSinglAcntAllResult result = client.REQ3_4_GET_FNLTT_SINGL_ACNT_ALL_INFO("00126380", "2018", "11011", "OFS");

                // 3.5. XBRL택사노미재무제표양식, sj_div=BS1
                // ResXbrlTaxonomyResult result = client.REQ3_5_GET_XBRL_TAXONOMY_INFO(OpenDartClient.SJ_DIV.BS2);
                //========================================================================

                //========================================================================
                // 4. 지분공시 종합정보 테스트 (REQ4_XXX)
                //========================================================================
                // 4.1. 대량보유 상황보고, corp_code=00126380
                // ResMajorstockResult result = client.REQ4_1_GET_MAJORSTOCK_INFO("00126380");

                // 4.2. 임원ㆍ주요주주 소유보고, corp_code=00126380
                // ResElestockResult result = client.REQ4_2_GET_ELESTOCK_INFO("00126380");
                //========================================================================

                // 결과 확인
                if (result != null)
                {
                    result.displayConsole();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("!!! EXCEPTION: " + e.Message);
                Console.WriteLine("*******************************************************************************");
            }
        }

        static void Test_PostgreSQL()
        {
            // using (var conn = new NpgsqlConnection("host=localhost;username=postgres;password=;database=postgres"))
            using (var conn = new NpgsqlConnection("host=localhost;username=bcadmin;password=1234;database=bc_db"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        // cmd.CommandText = 
                        //     "SELECT table_name " +
                        //     "FROM information_schema.tables " + "" +
                        //     "WHERE table_schema = 'public' AND table_type = 'BASE TABLE'";
                        cmd.CommandText = 
                            "SELECT * " +
                            "  FROM menu ";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // reader.GetName(0);
                                Console.WriteLine(reader.GetString(1));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
