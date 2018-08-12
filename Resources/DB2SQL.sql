

CREATE TABLE [dbo].[userlogin](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[level] [varchar](10) NULL,
	[fullname] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[userlogin] ([username], [password], [level], [fullname]) VALUES (N'admin', N'pass', N'admin', N'Admin Nazri.Ismail')
INSERT [dbo].[userlogin] ([username], [password], [level], [fullname]) VALUES (N'dr.azzah', N'dr', N'dr', N'Dr Nor Azzah')
INSERT [dbo].[userlogin] ([username], [password], [level], [fullname]) VALUES (N'dr.locum', N'dr', N'dr', N'Dr Locum')
/****** Object:  Table [dbo].[treatment_type]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[treatment_type](
	[tr_type] [nvarchar](10) NOT NULL,
	[tr_name] [varchar](50) NULL,
	[tr_defaultcharge] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[treatment_type] ([tr_type], [tr_name], [tr_defaultcharge]) VALUES (N'IJCT', N'Injection Demam', CAST(20.00 AS Numeric(18, 2)))
/****** Object:  Table [dbo].[template]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[template](
	[template_name] [nvarchar](50) NOT NULL,
	[rtf] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[metadata]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[metadata](
	[value_] [nvarchar](max) NOT NULL,
	[type_] [nvarchar](50) NOT NULL,
	[name_] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[metadata] ([value_], [type_], [name_]) VALUES (N'{\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff0\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi0\deflang17417\deflangfe17417\themelang17417\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f34\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria Math;}
{\f37\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhimajor\f31502\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0302020204030204}Calibri Light;}
{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhiminor\f31506\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}
{\fbiminor\f31507\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f39\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f40\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\f42\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f43\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\f44\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f45\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\f46\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\f47\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\f379\fbidi \froman\fcharset238\fprq2 Cambria Math CE;}{\f380\fbidi \froman\fcharset204\fprq2 Cambria Math Cyr;}
{\f382\fbidi \froman\fcharset161\fprq2 Cambria Math Greek;}{\f383\fbidi \froman\fcharset162\fprq2 Cambria Math Tur;}{\f386\fbidi \froman\fcharset186\fprq2 Cambria Math Baltic;}{\f387\fbidi \froman\fcharset163\fprq2 Cambria Math (Vietnamese);}
{\f409\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\f410\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\f412\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\f413\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
{\f416\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\f417\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\fhimajor\f31528\fbidi \fswiss\fcharset238\fprq2 Calibri Light CE;}{\fhimajor\f31529\fbidi \fswiss\fcharset204\fprq2 Calibri Light Cyr;}{\fhimajor\f31531\fbidi \fswiss\fcharset161\fprq2 Calibri Light Greek;}
{\fhimajor\f31532\fbidi \fswiss\fcharset162\fprq2 Calibri Light Tur;}{\fhimajor\f31535\fbidi \fswiss\fcharset186\fprq2 Calibri Light Baltic;}{\fhimajor\f31536\fbidi \fswiss\fcharset163\fprq2 Calibri Light (Vietnamese);}
{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\fhiminor\f31568\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\fhiminor\f31569\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\fhiminor\f31571\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\fhiminor\f31572\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
{\fhiminor\f31575\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\fhiminor\f31576\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\fbiminor\f31578\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\fbiminor\f31579\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbiminor\f31581\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbiminor\f31582\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\fbiminor\f31583\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbiminor\f31584\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbiminor\f31585\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\fbiminor\f31586\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;
\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;}{\*\defchp 
\fs22\loch\af31506\hich\af31506\dbch\af31505 }{\*\defpap \ql \li0\ri0\sa160\sl259\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }\noqfpromote {\stylesheet{\ql \li0\ri0\sa160\sl259\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af0\afs22\alang1025 \ltrch\fcs0 \fs22\lang17417\langfe17417\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp17417\langfenp17417 \snext0 \sqformat \spriority0 Normal;}
{\*\cs10 \additive \ssemihidden \sunhideused \spriority1 Default Paragraph Font;}{\*
\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa160\sl259\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af0\afs22\alang1025 \ltrch\fcs0 \fs22\lang17417\langfe17417\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp17417\langfenp17417 \snext11 \ssemihidden \sunhideused 
Normal Table;}}{\*\rsidtbl \rsid3374093\rsid5334318\rsid6511271\rsid9531941\rsid10297338}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0\mnaryLim1}{\info{\operator Nazri Ismail}
{\creatim\yr2015\mo4\dy10\hr17\min29}{\revtim\yr2015\mo4\dy11\hr20\min8}{\version5}{\edmins3}{\nofpages1}{\nofwords54}{\nofchars310}{\nofcharsws363}{\vern57433}}{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}
\paperw12240\paperh15840\margl1440\margr1440\margt1440\margb1440\gutter0\ltrsect 
\widowctrl\ftnbj\aenddoc\trackmoves0\trackformatting1\donotembedsysfont0\relyonvml0\donotembedlingdata1\grfdocevents0\validatexml0\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0\showxmlerrors0\horzdoc\dghspace120\dgvspace120\dghorigin1701
\dgvorigin1984\dghshow0\dgvshow3\jcompress\viewkind1\viewscale100\rsidroot9531941 \nouicompat \fet0{\*\wgrffmtfilter 2450}\nofeaturethrottle1\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\sectdefaultcl\sftnbj {\*\pnseclvl1
\pnucrm\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2\pnucltr\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl3\pndec\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5
\pndec\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnstart1\pnindent720\pnhang 
{\pntxtb (}{\pntxta )}}{\*\pnseclvl9\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}\pard\plain \ltrpar\qc \li0\ri-1158\nowidctlpar\tx8662\tx9798\wrapdefault\faauto\rin-1158\lin0\itap0 \rtlch\fcs1 \af0\afs22\alang1025 \ltrch\fcs0 
\fs22\lang17417\langfe17417\loch\af31506\hich\af31506\dbch\af31505\cgrid\langnp17417\langfenp17417 {\rtlch\fcs1 \ab\af37\afs48 \ltrch\fcs0 \b\f37\fs48\lang9\langfe17417\langnp9\insrsid5334318 {\*\bkmkstart OLE_LINK1}{\*\bkmkstart OLE_LINK2}--}{
\rtlch\fcs1 \ab\af37\afs48 \ltrch\fcs0 \b\f37\fs48\lang9\langfe17417\langnp9\insrsid9531941 \hich\af37\dbch\af31505\loch\f37 clinic}{\rtlch\fcs1 \ab\af37\afs48 \ltrch\fcs0 \b\f37\fs48\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 .name}{\rtlch\fcs1 \ab\af37\afs48 \ltrch\fcs0 \b\f37\fs48\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \ab\af37 \ltrch\fcs0 \b\f37\lang9\langfe17417\langnp9\insrsid6511271 
\par }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid5334318 {\*\bkmkend OLE_LINK1}{\*\bkmkend OLE_LINK2}--}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 clinik.address}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37 \ltrch\fcs0 \f37\lang9\langfe17417\langnp9\insrsid6511271 
\par }\pard \ltrpar\qc \li0\ri-1158\sl360\slmult1\nowidctlpar\tx8662\tx9798\wrapdefault\faauto\rin-1158\lin0\itap0 {\rtlch\fcs1 \af37 \ltrch\fcs0 \f37\lang9\langfe17417\langnp9\insrsid6511271 
\par }\pard \ltrpar\ql \li0\ri-1158\sl360\slmult1\nowidctlpar\tx8662\tx9798\wrapdefault\faauto\rin-1158\lin0\itap0 {\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\par \hich\af37\dbch\af31505\loch\f37 Kepada: }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid3374093 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 company.name}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid3374093 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\par 
\par \hich\af37\dbch\af31505\loch\f37 Tuan/Puan,
\par 
\par \hich\af37\dbch\af31505\loch\f37 Adalah dimaklumkan bahawa }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 patient.name}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 ,
\par }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37 IC }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 
\ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37 patient.ic}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 
\f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37  }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37  telah datang untuk rawatan pada tarikh }{
\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37 treatment.date}{\rtlch\fcs1 
\af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\par \hich\af37\dbch\af31505\loch\f37 mulai jam }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 treatment.starttime}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37  sehingga }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 
\hich\af37\dbch\af31505\loch\f37 treatment.endtime}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\ul\lang9\langfe17417\langnp9\insrsid6511271 
\par }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\par \hich\af37\dbch\af31505\loch\f37 Sekian,
\par \hich\af37\dbch\af31505\loch\f37 Terima kasih
\par 
\par --------------------------------------------
\par \hich\af37\dbch\af31505\loch\f37 Tandatangan Doktor
\par }{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 \hich\af37\dbch\af31505\loch\f37 doctor.name}{\rtlch\fcs1 \af37\afs28 
\ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid5334318 --}{\rtlch\fcs1 \af37\afs28 \ltrch\fcs0 \f37\fs28\lang9\langfe17417\langnp9\insrsid6511271 
\par }{\*\themedata 504b030414000600080000002100e9de0fbfff0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb4ec3301045f748fc83e52d4a
9cb2400825e982c78ec7a27cc0c8992416c9d8b2a755fbf74cd25442a820166c2cd933f79e3be372bd1f07b5c3989ca74aaff2422b24eb1b475da5df374fd9ad
5689811a183c61a50f98f4babebc2837878049899a52a57be670674cb23d8e90721f90a4d2fa3802cb35762680fd800ecd7551dc18eb899138e3c943d7e503b6
b01d583deee5f99824e290b4ba3f364eac4a430883b3c092d4eca8f946c916422ecab927f52ea42b89a1cd59c254f919b0e85e6535d135a8de20f20b8c12c3b0
0c895fcf6720192de6bf3b9e89ecdbd6596cbcdd8eb28e7c365ecc4ec1ff1460f53fe813d3cc7f5b7f020000ffff0300504b030414000600080000002100a5d6
a7e7c0000000360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4f
c7060abb0884a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b6309512
0f88d94fbc52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462
a1a82fe353bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f746865
6d652f7468656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b
4b0d592c9c070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b
4757e8d3f729e245eb2b260a0238fd010000ffff0300504b030414000600080000002100aa5225dfc60600008b1a0000160000007468656d652f7468656d652f
7468656d65312e786d6cec595d8bdb46147d2ff43f08bd3bfe92fcb1c41b6cd9ceb6d94d42eca4e4716c8fadc98e344633de8d0981923c160aa569e943037deb
43691b48a02fe9afd936a54d217fa17746b63c638fbb9b2585a5640d8b343af7ce997bafce1d4997afdc8fa87384134e58dc708b970aae83e3211b9178d2706f
f7bbb99aeb7081e211a22cc60d778eb97b65f7c30f2ea31d11e2083b601ff31dd4704321a63bf93c1fc230e297d814c7706dcc920809384d26f951828ec16f44
f3a542a1928f10895d274611b8bd311e932176fad2a5bbbb74dea1701a0b2e078634e949d7d8b050d8d1615122f89c0734718e106db830cf881df7f17de13a14
7101171a6e41fdb9f9ddcb79b4b330a2628bad66d7557f0bbb85c1e8b0a4e64c26836c52cff3bd4a33f3af00546ce23ad54ea553c9fc29001a0e61a52917dda7
dfaab7dafe02ab81d2438bef76b55d2e1a78cd7f798373d3973f03af40a97f6f03dfed06104503af4029dedfc07b5eb51478065e81527c65035f2d34db5ed5c0
2b5048497cb8812ef89572b05c6d061933ba6785d77daf5b2d2d9caf50500d5975c929c62c16db6a2d42f758d2058004522448ec88f9148fd110aa3840940c12
e2ec93490885374531e3305c2815ba8532fc973f4f1da988a01d8c346bc90b98f08d21c9c7e1c3844c45c3fd18bcba1ae4cdcb1fdfbc7cee9c3c7a71f2e89793
c78f4f1efd9c3a32acf6503cd1ad5e7fffc5df4f3f75fe7afeddeb275fd9f15cc7fffed367bffdfaa51d082b5d85e0d5d7cffe78f1ecd5379ffff9c3130bbc99
a0810eef930873e73a3e766eb10816a6426032c783e4ed2cfa2122ba45339e701423398bc57f478406fafa1c5164c1b5b019c13b09488c0d787576cf20dc0b93
9920168fd7c2c8001e30465b2cb146e19a9c4b0b737f164fec9327331d770ba123dbdc018a8dfc766653d05662731984d8a07993a258a0098eb170e4357688b1
6575770931e27a408609e36c2c9cbbc46921620d499f0c8c6a5a19ed9108f232b711847c1bb139b8e3b418b5adba8d8f4c24dc15885ac8f73135c27815cd048a
6c2efb28a27ac0f791086d247bf364a8e33a5c40a6279832a733c29cdb6c6e24b05e2de9d7405eec693fa0f3c84426821cda7cee23c674649b1d06218aa6366c
8fc4a18efd881f428922e7261336f80133ef10790e7940f1d674df21d848f7e96a701b9455a7b42a107965965872791533a37e7b733a4658490d08bfa1e71189
4f15f73559f7ff5b5907217df5ed53cbaa2eaaa0371362bda3f6d6647c1b6e5dbc03968cc8c5d7ee369ac53731dc2e9b0decbd74bf976ef77f2fdddbeee7772f
d82b8d06f9965bc574abae36eed1d67dfb9850da13738af7b9daba73e84ca32e0c4a3bf5cc8ab3e7b8690887f24e86090cdc2441cac64998f88488b017a229ec
ef8bae7432e10bd713ee4c19876dbf1ab6fa96783a8b0ed8287d5c2d16e5a3692a1e1c89d578c1cfc6e15143a4e84a75f50896b9576c27ea51794940dabe0d09
6d329344d942a2ba1c9441520fe610340b09b5b277c2a26e615193ee97a9da6001d4b2acc0d6c9810d57c3f53d30012378a242148f649ed2542fb3ab92f92e33
bd2d984605c03e625901ab4cd725d7adcb93ab4b4bed0c99364868e566925091513d8c87688417d52947cf42e36d735d5fa5d4a02743a1e683d25ad1a8d6fe8d
c579730d76ebda40635d2968ec1c37dc4ad9879219a269c31dc3633f1c4653a81d2eb7bc884ee0ddd95024e90d7f1e6599265cb4110fd3802bd149d520220227
0e2551c395cbcfd24063a5218a5bb104827061c9d541562e1a3948ba99643c1ee3a1d0d3ae8dc848a7a7a0f0a95658af2af3f383a5259b41ba7be1e8d819d059
720b4189f9d5a20ce0887078fb534ca33922f03a3313b255fdad35a685eceaef13550da5e3884e43b4e828ba98a77025e5191d7596c5403b5bac1902aa8564d1
080713d960f5a01add34eb1a2987ad5df7742319394d34573dd35015d935ed2a66ccb06c036bb13c5f93d7582d430c9aa677f854bad725b7bed4bab57d42d625
20e059fc2c5df70c0d41a3b69acca026196fcab0d4ecc5a8d93b960b3c85da599a84a6fa95a5dbb5b8653dc23a1d0c9eabf383dd7ad5c2d078b9af549156df3d
f44f136c700fc4a30d2f81675470954af8f09020d810f5d49e24950db845ee8bc5ad0147ce2c210df741c16f7a41c90f72859adfc97965af90abf9cd72aee9fb
e562c72f16daadd243682c228c8a7efacda50bafa2e87cf1e5458d6f7c7d89966fdb2e0d599467eaeb4a5e11575f5f8aa5ed5f5f1c02a2f3a052ead6cbf55625
572f37bb39afddaae5ea41a5956b57826abbdb0efc5abdfbd0758e14d86b9603afd2a9e52ac520c8799582a45fabe7aa5ea9d4f4aacd5ac76b3e5c6c6360e5a9
7c2c6201e155bc76ff010000ffff0300504b0304140006000800000021000dd1909fb60000001b010000270000007468656d652f7468656d652f5f72656c732f
7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f78277086f6fd3ba109126dd88d0add40384e4350d363f2451eced0dae2c082e8761be
9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89d93b64b060828e6f37ed1567914b284d262452282e3198720e274a939cd08a54f980
ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd5001996509affb3fd381a89672f1f165dfe514173d9850528a2c6cce0239baa4c04ca5b
babac4df000000ffff0300504b01022d0014000600080000002100e9de0fbfff0000001c0200001300000000000000000000000000000000005b436f6e74656e
745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6a7e7c0000000360100000b00000000000000000000000000300100005f72656c732f
2e72656c73504b01022d00140006000800000021006b799616830000008a0000001c00000000000000000000000000190200007468656d652f7468656d652f74
68656d654d616e616765722e786d6c504b01022d0014000600080000002100aa5225dfc60600008b1a00001600000000000000000000000000d6020000746865
6d652f7468656d652f7468656d65312e786d6c504b01022d00140006000800000021000dd1909fb60000001b0100002700000000000000000000000000d00900007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000cb0a00000000}
{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
{\*\latentstyles\lsdstimax371\lsdlockeddef0\lsdsemihiddendef0\lsdunhideuseddef0\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 5;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 6;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 7;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 8;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 9;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 1;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 2;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 3;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 4;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 5;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 6;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 7;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 8;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 header;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footer;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index heading;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of figures;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope return;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation reference;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 line number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 page number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote text;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of authorities;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 macro;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 toa heading;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 5;\lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Closing;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Signature;\lsdsemihidden1 \lsdunhideused1 \lsdpriority1 \lsdlocked0 Default Paragraph Font;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 4;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Message Header;\lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Salutation;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Date;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Note Heading;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Block Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Hyperlink;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 FollowedHyperlink;\lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;
\lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Document Map;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Plain Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 E-mail Signature;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Top of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Bottom of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal (Web);\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Acronym;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Cite;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Code;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Definition;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Keyboard;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Preformatted;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Sample;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Typewriter;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Variable;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation subject;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 No List;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Balloon Text;\lsdpriority39 \lsdlocked0 Table Grid;
\lsdsemihidden1 \lsdlocked0 Placeholder Text;\lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;\lsdpriority60 \lsdlocked0 Light Shading;\lsdpriority61 \lsdlocked0 Light List;\lsdpriority62 \lsdlocked0 Light Grid;
\lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdpriority64 \lsdlocked0 Medium Shading 2;\lsdpriority65 \lsdlocked0 Medium List 1;\lsdpriority66 \lsdlocked0 Medium List 2;\lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdpriority68 \lsdlocked0 Medium Grid 2;
\lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdpriority70 \lsdlocked0 Dark List;\lsdpriority71 \lsdlocked0 Colorful Shading;\lsdpriority72 \lsdlocked0 Colorful List;\lsdpriority73 \lsdlocked0 Colorful Grid;\lsdpriority60 \lsdlocked0 Light Shading Accent 1;
\lsdpriority61 \lsdlocked0 Light List Accent 1;\lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;
\lsdsemihidden1 \lsdlocked0 Revision;\lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;
\lsdpriority72 \lsdlocked0 Colorful List Accent 1;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdpriority60 \lsdlocked0 Light Shading Accent 2;\lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdpriority62 \lsdlocked0 Light Grid Accent 2;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;\lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;
\lsdpriority72 \lsdlocked0 Colorful List Accent 2;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;\lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdpriority61 \lsdlocked0 Light List Accent 3;\lsdpriority62 \lsdlocked0 Light Grid Accent 3;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;\lsdpriority70 \lsdlocked0 Dark List Accent 3;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;
\lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;\lsdpriority60 \lsdlocked0 Light Shading Accent 4;\lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdpriority62 \lsdlocked0 Light Grid Accent 4;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdpriority70 \lsdlocked0 Dark List Accent 4;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;
\lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdpriority60 \lsdlocked0 Light Shading Accent 5;\lsdpriority61 \lsdlocked0 Light List Accent 5;\lsdpriority62 \lsdlocked0 Light Grid Accent 5;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;\lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;
\lsdpriority72 \lsdlocked0 Colorful List Accent 5;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdpriority61 \lsdlocked0 Light List Accent 6;\lsdpriority62 \lsdlocked0 Light Grid Accent 6;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdpriority70 \lsdlocked0 Dark List Accent 6;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;
\lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;\lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
\lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;\lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdsemihidden1 \lsdunhideused1 \lsdpriority37 \lsdlocked0 Bibliography;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;\lsdpriority41 \lsdlocked0 Plain Table 1;\lsdpriority42 \lsdlocked0 Plain Table 2;\lsdpriority43 \lsdlocked0 Plain Table 3;\lsdpriority44 \lsdlocked0 Plain Table 4;
\lsdpriority45 \lsdlocked0 Plain Table 5;\lsdpriority40 \lsdlocked0 Grid Table Light;\lsdpriority46 \lsdlocked0 Grid Table 1 Light;\lsdpriority47 \lsdlocked0 Grid Table 2;\lsdpriority48 \lsdlocked0 Grid Table 3;\lsdpriority49 \lsdlocked0 Grid Table 4;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 1;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 1;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 1;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 1;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 1;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 2;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 2;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 2;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 2;
\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 3;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 3;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 3;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 3;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 3;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 4;
\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 4;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 4;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 4;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 4;
\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 4;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 5;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 5;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 5;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 5;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 5;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 6;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 6;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 6;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 6;
\lsdpriority46 \lsdlocked0 List Table 1 Light;\lsdpriority47 \lsdlocked0 List Table 2;\lsdpriority48 \lsdlocked0 List Table 3;\lsdpriority49 \lsdlocked0 List Table 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful;\lsdpriority52 \lsdlocked0 List Table 7 Colorful;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 List Table 2 Accent 1;\lsdpriority48 \lsdlocked0 List Table 3 Accent 1;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 1;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 1;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 1;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 List Table 2 Accent 2;\lsdpriority48 \lsdlocked0 List Table 3 Accent 2;\lsdpriority49 \lsdlocked0 List Table 4 Accent 2;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 2;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 3;
\lsdpriority47 \lsdlocked0 List Table 2 Accent 3;\lsdpriority48 \lsdlocked0 List Table 3 Accent 3;\lsdpriority49 \lsdlocked0 List Table 4 Accent 3;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 3;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 4;\lsdpriority47 \lsdlocked0 List Table 2 Accent 4;
\lsdpriority48 \lsdlocked0 List Table 3 Accent 4;\lsdpriority49 \lsdlocked0 List Table 4 Accent 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 4;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 4;
\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 List Table 2 Accent 5;\lsdpriority48 \lsdlocked0 List Table 3 Accent 5;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 5;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 5;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 5;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 List Table 2 Accent 6;\lsdpriority48 \lsdlocked0 List Table 3 Accent 6;\lsdpriority49 \lsdlocked0 List Table 4 Accent 6;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 6;}}{\*\datastore 010500000200000018000000
4d73786d6c322e534158584d4c5265616465722e362e3000000000000000000000060000
d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
fffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff0c6ad98892f1d411a65f0040963251e5000000000000000000000000f080
ac2d5074d001feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000000000105000000000000}}', N'MC', N'MC1')
/****** Object:  Table [dbo].[log_sync]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[log_sync](
	[table_name] [varchar](10) NOT NULL,
	[datetime] [datetime] NOT NULL,
	[user_name] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employerinfo]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employerinfo](
	[employeer_code] [varchar](10) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](max) NULL,
	[contact] [varchar](10) NULL,
	[notes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[employerinfo] ([employeer_code], [name], [address], [contact], [notes]) VALUES (N'CASH', N'CASH', NULL, NULL, NULL)
/****** Object:  Table [dbo].[drug]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drug](
	[drg_code] [nvarchar](10) NOT NULL,
	[drg_name] [nvarchar](50) NOT NULL,
	[drg_brand] [nvarchar](50) NULL,
	[drg_type] [nvarchar](50) NULL,
	[drg_group] [nvarchar](50) NULL,
	[drg_subgroup] [nvarchar](50) NULL,
	[drg_sellingpriceperunit] [numeric](18, 2) NOT NULL,
	[drg_use_for] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[drug] ([drg_code], [drg_name], [drg_brand], [drg_type], [drg_group], [drg_subgroup], [drg_sellingpriceperunit], [drg_use_for]) VALUES (N'PAN', N'PANADOL', N'PANADOL', N'MED', NULL, NULL, CAST(50.00 AS Numeric(18, 2)), N'Demam, Sakit kepala, Sakit Urat')
/****** Object:  Table [dbo].[diagnosis]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[diagnosis](
	[diag_id] [int] IDENTITY(1,1) NOT NULL,
	[diag_type] [varchar](max) NULL,
	[diag_name] [varchar](50) NOT NULL,
	[diag_note] [varchar](max) NULL,
	[diag_completetime] [datetime] NULL,
	[q_id] [int] NULL,
	[diag_addchrg] [numeric](18, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[diagnosis] ON
INSERT [dbo].[diagnosis] ([diag_id], [diag_type], [diag_name], [diag_note], [diag_completetime], [q_id], [diag_addchrg]) VALUES (1, N'asdac
asasd', N'Xray', N'cac
asd', NULL, 2, CAST(30.00 AS Numeric(18, 2)))
INSERT [dbo].[diagnosis] ([diag_id], [diag_type], [diag_name], [diag_note], [diag_completetime], [q_id], [diag_addchrg]) VALUES (2, N'adas
asd
asd', N'Xray', N'asd
asds
ass', CAST(0x0000A46F00000000 AS DateTime), 4, CAST(12.00 AS Numeric(18, 2)))
INSERT [dbo].[diagnosis] ([diag_id], [diag_type], [diag_name], [diag_note], [diag_completetime], [q_id], [diag_addchrg]) VALUES (3, N'1', N'1', N'1', CAST(0x0000A47B00000000 AS DateTime), 3, CAST(11.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[diagnosis] OFF
/****** Object:  Table [dbo].[payment]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[payment](
	[pay_id] [int] IDENTITY(1,1) NOT NULL,
	[pay_staffid] [varchar](50) NOT NULL,
	[pay_amt] [decimal](18, 2) NOT NULL,
	[pay_bal] [decimal](18, 2) NULL,
	[datetime] [datetime] NOT NULL,
	[pay_type] [varchar](50) NOT NULL,
	[q_id] [int] NOT NULL,
	[reciept] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[payment] ON
INSERT [dbo].[payment] ([pay_id], [pay_staffid], [pay_amt], [pay_bal], [datetime], [pay_type], [q_id], [reciept]) VALUES (1, N'admin', CAST(270.00 AS Decimal(18, 2)), CAST(-270.00 AS Decimal(18, 2)), CAST(0x0000A47D00C78DBA AS DateTime), N'CASH', 1, N' ---------------------------------------------------------- 
                  TREATMENT INFO                           
  NO              1                                        
  NAME            Mohd Nazri Bin Ismail                    
  DR              admin                                    
  TIME ENTER      17/4/2015 12:02:28 PM                    
  REMARKS         This is the first visit for this patient 

 ---------------------------------------------------------------------- 
  DRUG CODE   QTY         UNIT PRICE  TOTAL       REMARKS              
  PAN         5           50.00       250.00      Makan 3 bijik sehari 

 ------------------------------------------------------------------------------------- 
  TREATMT. TYPE    CONSULT. CHARGE  CHARGE           TOTAL            REMARKS         
  IJCT             0.00             20.00            20.00                            

 ---------------------------- 
                TOTAL CHARGE 
  TOTAL(RM)     270.00       

')
INSERT [dbo].[payment] ([pay_id], [pay_staffid], [pay_amt], [pay_bal], [datetime], [pay_type], [q_id], [reciept]) VALUES (2, N'admin', CAST(12.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000A47D01561DC6 AS DateTime), N'CASH', 4, N' --------------------------------------- 
                  TREATMENT INFO        
  NO              4                     
  NAME            Mohd Nazri Bin Ismail 
  DR              admin                 
  TIME ENTER      17/4/2015 4:17:13 PM  
  REMARKS         remarks               

 ---------------------------------- 
  DIAG. ID         CONSULT. CHARGE 
  2                12.00           

 ---------------------------- 
                TOTAL CHARGE 
  TOTAL(RM)     12.00        

')
INSERT [dbo].[payment] ([pay_id], [pay_staffid], [pay_amt], [pay_bal], [datetime], [pay_type], [q_id], [reciept]) VALUES (3, N'admin', CAST(239.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(0x0000A47D0156520F AS DateTime), N'POSMAL', 2, N' --------------------------------------- 
                  TREATMENT INFO        
  NO              2                     
  NAME            Mohd Nazri Bin Ismail 
  DR              admin                 
  TIME ENTER      17/4/2015 2:23:32 PM  
  REMARKS         2 Test patient        

 --------------------------------------------------------------------- 
  DRUG CODE   QTY         UNIT PRICE  TOTAL       REMARKS             
  PAN         3           50.00       150.00      makan sehari sekali 

 ------------------------------------------------------------------------------------- 
  TREATMT. TYPE    CONSULT. CHARGE  CHARGE           TOTAL            REMARKS         
  IJCT             39.00            20.00            59.00                            

 ---------------------------------- 
  DIAG. ID         CONSULT. CHARGE 
  1                30.00           

 ---------------------------- 
                TOTAL CHARGE 
  TOTAL(RM)     239.00       

')
INSERT [dbo].[payment] ([pay_id], [pay_staffid], [pay_amt], [pay_bal], [datetime], [pay_type], [q_id], [reciept]) VALUES (4, N'admin', CAST(500.00 AS Decimal(18, 2)), CAST(-500.00 AS Decimal(18, 2)), CAST(0x0000A47E0102E70C AS DateTime), N'CASH', 6, N' --------------------------------------- 
                  TREATMENT INFO        
  NO              6                     
  NAME            Mohd Nazri Bin Ismail 
  DR              admin                 
  TIME ENTER      18/4/2015 3:41:03 PM  
  REMARKS         this is a test        

 ------------------------------------------------------------ 
  DRUG CODE   QTY         UNIT PRICE  TOTAL       REMARKS    
  PAN         10          50.00       500.00      iadj       

 ---------------------------- 
                TOTAL CHARGE 
  TOTAL(RM)     500.00       

')
SET IDENTITY_INSERT [dbo].[payment] OFF
/****** Object:  Table [dbo].[patient]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patient](
	[pat_id] [int] IDENTITY(1,1) NOT NULL,
	[pat_name] [nvarchar](50) NOT NULL,
	[pat_ic] [varchar](50) NOT NULL,
	[pat_gender] [varchar](10) NULL,
	[pat_dob] [datetime] NULL,
	[pat_marital_status] [varchar](50) NULL,
	[pat_race] [varchar](50) NULL,
	[pat_occupation] [varchar](50) NULL,
	[pat_employeer] [varchar](50) NULL,
	[pat_hphone] [varchar](50) NULL,
	[pat_email] [varchar](50) NULL,
	[pat_address] [varchar](max) NULL,
	[pat_remarks] [varchar](max) NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[pat_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ__patient__0000000000000024] ON [dbo].[patient] 
(
	[pat_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient] ON
INSERT [dbo].[patient] ([pat_id], [pat_name], [pat_ic], [pat_gender], [pat_dob], [pat_marital_status], [pat_race], [pat_occupation], [pat_employeer], [pat_hphone], [pat_email], [pat_address], [pat_remarks]) VALUES (1, N'Mohd Nazri Bin Ismail', N'890407075221', N'MALE', NULL, N'SINGLE', N'malay', N'programmer', NULL, N'0134386495', N'mnazrii@live.com', N'10656 Jalan Hj Murshid Pekan Darat Sg Dua
13800 Butterworth
Pulau Pinang', N'This is the first patient info entered')
SET IDENTITY_INSERT [dbo].[patient] OFF
/****** Object:  Table [dbo].[queue]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[queue](
	[q_id] [int] IDENTITY(1,1) NOT NULL,
	[pat_id] [int] NULL,
	[doc_id] [nvarchar](50) NULL,
	[time_enter] [datetime] NULL,
	[time_out] [datetime] NULL,
	[q_status] [nvarchar](100) NULL,
	[note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Queue] PRIMARY KEY CLUSTERED 
(
	[q_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ__Queue__0000000000000045] ON [dbo].[queue] 
(
	[q_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[queue] ON
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (1, 1, N'Nazri', CAST(0x0000A47D00C66E82 AS DateTime), CAST(0x0000A47D00C78DBC AS DateTime), N'QP', N'This is the first visit for this patient')
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (2, 1, N'admin', CAST(0x0000A47D00ED2D3A AS DateTime), CAST(0x0000A47D01565210 AS DateTime), N'QE', N'2 Test patient')
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (3, 1, N'admin', CAST(0x0000A47D00F32651 AS DateTime), NULL, N'QP', NULL)
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (4, 1, N'admin', CAST(0x0000A47D010C675F AS DateTime), CAST(0x0000A47D01561DCA AS DateTime), N'QE', N'remarks')
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (5, 1, N'admin', CAST(0x0000A47D0155F3D8 AS DateTime), NULL, N'QP', NULL)
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (6, 1, N'admin', CAST(0x0000A47E010277AB AS DateTime), CAST(0x0000A47E0102E70E AS DateTime), N'QE', N'this is a test')
INSERT [dbo].[queue] ([q_id], [pat_id], [doc_id], [time_enter], [time_out], [q_status], [note]) VALUES (7, 1, N'dr.locum', CAST(0x0000A47E010A1CBC AS DateTime), NULL, N'QD', NULL)
SET IDENTITY_INSERT [dbo].[queue] OFF
/****** Object:  Table [dbo].[q_treatment]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[q_treatment](
	[tr_id] [int] IDENTITY(1,1) NOT NULL,
	[tr_type] [nvarchar](10) NOT NULL,
	[tr_note] [nvarchar](max) NULL,
	[q_id] [int] NOT NULL,
	[tr_additionalchg] [numeric](18, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[q_treatment] ON
INSERT [dbo].[q_treatment] ([tr_id], [tr_type], [tr_note], [q_id], [tr_additionalchg]) VALUES (1, N'IJCT', NULL, 1, CAST(0.00 AS Numeric(18, 2)))
INSERT [dbo].[q_treatment] ([tr_id], [tr_type], [tr_note], [q_id], [tr_additionalchg]) VALUES (2, N'IJCT', NULL, 2, CAST(39.00 AS Numeric(18, 2)))
INSERT [dbo].[q_treatment] ([tr_id], [tr_type], [tr_note], [q_id], [tr_additionalchg]) VALUES (3, N'IJCT', N'iii', 3, CAST(90.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[q_treatment] OFF
/****** Object:  Table [dbo].[q_drug]    Script Date: 04/18/2015 22:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[q_drug](
	[drug_code] [nvarchar](50) NOT NULL,
	[q_id] [int] NOT NULL,
	[qty] [int] NULL,
	[note] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[q_drug] ([drug_code], [q_id], [qty], [note]) VALUES (N'PAN', 1, 5, N'Makan 3 bijik sehari')
INSERT [dbo].[q_drug] ([drug_code], [q_id], [qty], [note]) VALUES (N'PAN', 2, 3, N'makan sehari sekali')
INSERT [dbo].[q_drug] ([drug_code], [q_id], [qty], [note]) VALUES (N'PAN', 6, 10, N'iadj')
INSERT [dbo].[q_drug] ([drug_code], [q_id], [qty], [note]) VALUES (N'PAN', 3, 1, NULL)
INSERT [dbo].[q_drug] ([drug_code], [q_id], [qty], [note]) VALUES (N'PAN', 1, 2, NULL)
/****** Object:  View [dbo].[PAYTYPEnMONTH]    Script Date: 04/18/2015 22:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CReate view [dbo].[PAYTYPEnMONTH]

as
select DATEADD(MONTH, DATEDIFF(MONTH, 0, [datetime]), 0) [MONTH],SUM(pay_amt)as [TOTAL AMT.],pay_type [PYMNT TYP/PANEL]  from payment
group by DATEADD(MONTH, DATEDIFF(MONTH, 0, [datetime]), 0),pay_type
GO
/****** Object:  View [dbo].[PAYTYPEnDATE]    Script Date: 04/18/2015 22:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CReate view [dbo].[PAYTYPEnDATE]

as
SELECT CAST([Datetime] AS DATE) as [VISIT DATE], SUM(pay_amt)as [TOTAL AMT.],pay_type [PYMNT TYP/PANEL] 
FROM payment
GROUP BY CAST([Datetime] AS DATE),pay_type
GO
/****** Object:  View [dbo].[PAYMENTREPORT]    Script Date: 04/18/2015 22:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[PAYMENTREPORT] as

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [pay_amt] [AMNT.]
      ,CAST([Datetime] AS DATE) as [DATE]
      ,doc_id [DR]
      ,[pay_type] [PAYMENT TYPE]
  FROM [dbo].[payment]p 
  
  join [queue]q on q.q_id=p.q_id
GO
/****** Object:  View [dbo].[PAYMENTDETAILS]    Script Date: 04/18/2015 22:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[PAYMENTDETAILS] as
select pay_id,CAST([Datetime] AS DATE) as [DATE],pt.pay_staffid,pt.pay_type [PAYMENT TYPE],pay_amt,q.q_id,pat_name,doc_id,pt.reciept from [patient]p join [queue]q on q.pat_id=p.pat_id
join payment pt on pt.q_id=q.q_id
GO
/****** Object:  View [dbo].[MRTLST]    Script Date: 04/18/2015 22:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MRTLST]
AS
SELECT   value_
FROM      dbo.metadata
WHERE   (type_ = 'MRTLST')
GO

GO
/****** Object:  StoredProcedure [dbo].[DeleteQInfo]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[DeleteQInfo]

	(
	@qid varchar(max)
	)
	
AS
	delete from q_treatment where q_id=@qid
	delete from q_drug where q_id=@qid
	delete from diagnosis where q_id=@qid

	RETURN
GO
/****** Object:  StoredProcedure [dbo].[calcCharge]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[calcCharge] 
(@qid varchar(10))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT   
  tblPivot.Property [  ] , tblPivot.Value [TREATMENT INFO] 
FROM (
	select 
	  CONVERT(sql_variant,Q_ID		 )	NO,
	  CONVERT(sql_variant,PAT_NAME	 )	[NAME],
	  CONVERT(sql_variant,DOC_ID	 )	DR,
	  CONVERT(sql_variant,TIME_ENTER )  [TIME ENTER],
	  CONVERT(sql_variant,Q.NOTE	 )	REMARKS  
	
	from [queue] Q JOIN PATIENT P ON(P.PAT_ID=Q.PAT_ID) where q_id=@qid
	)PAT
	UNPIVOT (Value For Property In (
			NO,
			[NAME],
			DR,
			[TIME ENTER],
			REMARKS  

	)) as tblPivot;

	
	select drug_code [DRUG CODE],qty QTY,drg_sellingpriceperunit [UNIT PRICE],drg_sellingpriceperunit*qty [TOTAL],note REMARKS from q_drug qd join drug d on qd.drug_code=d.drg_code where q_id=@qid
	select tt.tr_type [TREATMT. TYPE],tr_additionalchg [CONSULT. CHARGE],tr_defaultcharge [CHARGE],tr_additionalchg+tr_defaultcharge TOTAL, tr_note [REMARKS] from q_treatment qt join treatment_type tt on (tt.tr_type=qt.tr_type) where q_id=@qid
	select diag_id [DIAG. ID],diag_addchrg [CONSULT. CHARGE] from dbo.diagnosis where q_id=@qid
	
	select 'TOTAL(RM)' [ ],sum(total) [TOTAL CHARGE] FROM(
	select drg_sellingpriceperunit*qty [TOTAL] from q_drug qd join drug d on qd.drug_code=d.drg_code where q_id=@qid
	union
	select tr_additionalchg+tr_defaultcharge TOTAL from q_treatment qt join treatment_type tt on (tt.tr_type=qt.tr_type) where q_id=@qid
	union
	select diag_addchrg [TOTAL] from dbo.diagnosis where q_id=@qid
	 )TTL	
END
GO
/****** Object:  View [dbo].[DRView]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DRView]
AS
SELECT   username
FROM      dbo.userlogin
WHERE   (level = 'DR')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "userlogin"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 173
               Right = 239
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DRView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DRView'
GO
/****** Object:  View [dbo].[GNDLST]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GNDLST]
AS
SELECT   value_, name_
FROM      dbo.metadata
WHERE   (type_ = 'GND')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "metadata"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 130
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GNDLST'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GNDLST'
GO
/****** Object:  StoredProcedure [dbo].[SelectQuery]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectQuery]
(
	@username varchar(20),
	@password varchar(20)
)
AS
	SET NOCOUNT ON;
SELECT   *
FROM      userlogin
WHERE   username = @username and  password=@password
GO
/****** Object:  View [dbo].[RCLST]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RCLST]
AS
SELECT   value_
FROM      dbo.metadata
WHERE   (type_ = 'RCLST')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "metadata"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 130
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RCLST'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RCLST'
GO
/****** Object:  View [dbo].[QueuePayment]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QueuePayment]
AS
SELECT   q_id AS Q#, pat_id AS PatientID, doc_id AS DR, time_enter AS [TIME ENTER], q_status AS STATUS, note
FROM      dbo.queue
WHERE   (q_status = 'QP')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "queue"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 149
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueuePayment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueuePayment'
GO
/****** Object:  View [dbo].[QueueEnded]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QueueEnded]
AS
SELECT   q_id AS Q#, pat_id AS PatientID, doc_id AS DR, time_enter AS [TIME ENTER], time_out AS [TIME OUT], q_status AS STATUS, note
FROM      dbo.queue
WHERE   (q_status = 'QE')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "queue"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 149
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 897
         Table = 1168
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1345
         SortOrder = 1413
         GroupBy = 1350
         Filter = 1345
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueueEnded'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueueEnded'
GO
/****** Object:  View [dbo].[QueueDoctor]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QueueDoctor]
AS
SELECT   q_id AS Q#, pat_id AS PatientID, doc_id AS DR, time_enter AS [TIME ENTER], q_status AS STATUS, note AS NOTE
FROM      dbo.queue
WHERE   (q_status = 'QD')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "queue"
            Begin Extent = 
               Top = 6
               Left = 42
               Bottom = 149
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
         Width = 1358
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueueDoctor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QueueDoctor'
GO
/****** Object:  View [dbo].[SUMMONTH]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SUMMONTH] AS
select [MONTH] [DATE],sum([total amt.]) TOTAL from dbo.PAYTYPEnMONTH group by [MONTH]
GO
/****** Object:  View [dbo].[SUMDATE]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SUMDATE] AS
select [VISIT DATE] [DATE],sum([total amt.]) TOTAL from dbo.PAYTYPEnDATE group by [visit date]
GO
/****** Object:  StoredProcedure [dbo].[AllQueue]    Script Date: 04/18/2015 22:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AllQueue]
	
AS
	select  [Q#],pat_name [Name],pat_ic IC
	
	
      ,[PatientID]
      ,[DR]
      ,[TIME ENTER]
      ,[STATUS]
      ,q.[NOTE]
	   from queuedoctor q join patient p on (p.pat_id=q. PatientID) ;
	select [Q#],pat_name [Name],pat_ic IC
      ,[PatientID]
      ,[DR]
      ,[TIME ENTER]
      ,[STATUS]
      ,q.[NOTE] from queueended q join patient p on (p.pat_id=q. PatientID) ;
	
	select  [Q#],pat_name [Name],pat_ic IC
      ,[PatientID]
      ,[DR]
      ,[TIME ENTER]
      ,[STATUS]
      ,q.[NOTE]
	   from queuepayment q join patient p on (p.pat_id=q. PatientID) ;

	RETURN
GO
