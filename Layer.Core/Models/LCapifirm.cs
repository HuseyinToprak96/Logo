﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapifirm
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Street { get; set; }
        public string Road { get; set; }
        public string Doornr { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Taxoff { get; set; }
        public string Taxnr { get; set; }
        public string Securnr { get; set; }
        public string Direct { get; set; }
        public string Cpaname { get; set; }
        public string Cpastreet { get; set; }
        public string Cparoad { get; set; }
        public string Cpadoornr { get; set; }
        public string Cpadistrict { get; set; }
        public string Cpacity { get; set; }
        public string Cpaphone { get; set; }
        public string Cpataxoff { get; set; }
        public string Cpataxnr { get; set; }
        public string Cpachambnr { get; set; }
        public short? Begmon { get; set; }
        public short? Begday { get; set; }
        public int? Userext { get; set; }
        public short? Pernr { get; set; }
        public short? Countofleg { get; set; }
        public string Ctable { get; set; }
        public short? Workdayflgs1 { get; set; }
        public short? Workdayflgs2 { get; set; }
        public short? Workdayflgs3 { get; set; }
        public short? Workdayflgs4 { get; set; }
        public short? Workdayflgs5 { get; set; }
        public short? Workdayflgs6 { get; set; }
        public short? Workdayflgs7 { get; set; }
        public short? Localctyp { get; set; }
        public short? Firmrepcurr { get; set; }
        public short? Sepexchtable { get; set; }
        public short? Vatroundmtd { get; set; }
        public string Firmeuvatnumber { get; set; }
        public short? Majversnr { get; set; }
        public short? Minversnr { get; set; }
        public short? Relversnr { get; set; }
        public short? Siteid { get; set; }
        public int? Orgchart { get; set; }
        public short? Localcaldr { get; set; }
        public short? Firmlang { get; set; }
        public string Taxoffcode { get; set; }
        public string Cntrycode { get; set; }
        public short? Longperiods { get; set; }
        public string Logoid { get; set; }
        public string Emailaddr { get; set; }
        public string Webaddr { get; set; }
        public DateTime? Moddate { get; set; }
        public int? Modtime { get; set; }
        public string Traderegisno { get; set; }
        public string Employername { get; set; }
        public string Employersurname { get; set; }
        public string Employeridtcno { get; set; }
        public string Employeremail { get; set; }
        public short? Firmytlstatus { get; set; }
        public short? Ytlsourcefirm { get; set; }
        public string Zusatzno { get; set; }
        public string Taxoffstatecd { get; set; }
        public string Taxoffstatenm { get; set; }
        public string Statecode { get; set; }
        public string Statename { get; set; }
        public string Cpaoccupation { get; set; }
        public string Cpaextension { get; set; }
        public string Cpaemail { get; set; }
        public string Cpasurname { get; set; }
        public string Cpaidtcno { get; set; }
        public string Accofficecode { get; set; }
        public short? Advancedproduct { get; set; }
        public string Bagkurnr { get; set; }
        public string Username { get; set; }
        public string Dbname { get; set; }
        public string Password { get; set; }
        public short? Actarea { get; set; }
        public short? Sector { get; set; }
        public string Srccriteria { get; set; }
        public int? Conscoderef { get; set; }
        public string Tcellappid { get; set; }
        public string Tcellapppw { get; set; }
        public short? Dncnstlen { get; set; }
        public short? Useserverdate { get; set; }
        public short? Usechangelog { get; set; }
        public string Mobusername { get; set; }
        public string Mobpassword { get; set; }
        public string Mobfirmalias { get; set; }
        public short? Accepteinv { get; set; }
        public string Einvoiceid { get; set; }
        public string Profileid { get; set; }
        public short? Usecommonparam { get; set; }
        public short? Passive { get; set; }
        public string Usercode { get; set; }
        public string Parole { get; set; }
        public string Passwordtaxdecl { get; set; }
        public string Firmemailaddr { get; set; }
        public short? Firmtype { get; set; }
        public string Nacecode { get; set; }
        public string Cpacountry { get; set; }
        public string Cpazipcode { get; set; }
        public string Cpafaxnr { get; set; }
        public string Cpacntrycode { get; set; }
        public short? Useebook { get; set; }
        public string Contractdesc { get; set; }
        public string Contracttype { get; set; }
        public DateTime? Contractdate { get; set; }
        public string Contractnumber { get; set; }
        public string Hashvers { get; set; }
        public string Timestampuser { get; set; }
        public string Timestamppass { get; set; }
        public string Timestampserver { get; set; }
        public short? Useproxy { get; set; }
        public string Ptimestampuser { get; set; }
        public string Ptimestamppass { get; set; }
        public string Ptimestamphost { get; set; }
        public int? Ptimestampport { get; set; }
        public int? Timestampport { get; set; }
        public string Timestampapppth { get; set; }
        public string Jgserverurl { get; set; }
        public string Jgusername { get; set; }
        public string Jgpassword { get; set; }
        public int? Jgcompanynr { get; set; }
        public int? Jgperiodnr { get; set; }
        public string Jghrfirmcode { get; set; }
        public double? Deductlimit { get; set; }
        public string Postlabelcode { get; set; }
        public string Senderlabelcode { get; set; }
        public short? Einvconttype { get; set; }
        public short? Ebookconttype { get; set; }
        public string Mersisno { get; set; }
        public string Officaltitle { get; set; }
        public short? Useearchive { get; set; }
        public string Intsalesaddr { get; set; }
        public string Faxusername { get; set; }
        public string Faxuserkey { get; set; }
        public string Faxemailaddr { get; set; }
        public DateTime? Ebookstartdate { get; set; }
        public short? Ebookcurrtype { get; set; }
        public short? Earcentsend { get; set; }
        public string Earcentuser { get; set; }
        public string Earcentpass { get; set; }
        public string Earcentdefaddr { get; set; }
        public short? Cpatitle { get; set; }
        public short? Isebookkeptbyfirm { get; set; }
        public short? Isymmcontractmade { get; set; }
        public string Ymmname { get; set; }
        public string Ymmsurname { get; set; }
        public string Ymmcontdesc { get; set; }
        public string Ymmconttype { get; set; }
        public int? Ymmcontdate { get; set; }
        public string Ymmcontnumber { get; set; }
        public int? Lastcontrolno { get; set; }
        public int? Lastjournalno { get; set; }
        public int? Lastgloblineno { get; set; }
        public short? Backupebooks { get; set; }
        public short? Einvcustom { get; set; }
        public string Ymmphone { get; set; }
        public string Ymmfaxnr { get; set; }
        public string Ymmemail { get; set; }
        public short? Einvoicetypsgk { get; set; }
        public string Taxpayercode { get; set; }
        public string Taxpayername { get; set; }
        public string Ymmchambnr { get; set; }
        public string Ymmtcno { get; set; }
        public string Ymmtaxnr { get; set; }
        public short? Useedespatch { get; set; }
        public string Postlabelcodedesp { get; set; }
        public string Senderlabelcodedesp { get; set; }
        public short? Shaalgorithm { get; set; }
        public short? Useeproducerrec { get; set; }
        public short? Useetradesmaninv { get; set; }
        public string Cpausername { get; set; }
        public string Cpakdspassword { get; set; }
        public short? Getcpafromdiv { get; set; }
        public short? Liquidationtyp { get; set; }
        public int? Liquidatingdate { get; set; }
        public short? Liquidatedfirm { get; set; }
        public short? Usepaperinv { get; set; }
        public short? Cpatckn { get; set; }
        public string Shpagncod { get; set; }
        public string Usercode2 { get; set; }
        public string Parole2 { get; set; }
        public string Passwordtaxdecl2 { get; set; }
        public short? Emutentsend { get; set; }
        public string Emutentuser { get; set; }
        public string Emutentpass { get; set; }
        public string Emutentdefaddr { get; set; }
        public short? Getwhrexchcur { get; set; }
        public short? Exchcurrtype { get; set; }
        public short? Isccclient { get; set; }
        public short? Mmgibbooktype { get; set; }
        public string Mmgibclientid { get; set; }
        public short? Mmgibbookinteg { get; set; }
        public string Webnavisvcurl { get; set; }
        public string Eturmobtoken { get; set; }
        public short? Uetdsuser { get; set; }
        public string Uetdsusername { get; set; }
        public string Uetdspass { get; set; }
        public string Uetdsdefaddr { get; set; }
        public short? Mmgibworktype { get; set; }
    }
}
