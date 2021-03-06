USE [database_klinik]
GO

truncate table [dbo].[metadata]
INSERT [dbo].[metadata] ([value_], [type_], [name_]) VALUES (N'{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}{\f1\fnil\fcharset0 Consolas;}}
{\colortbl ;\red255\green255\blue255;\red163\green21\blue21;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sl240\slmult1\qc\highlight1\b\f0\fs24 KLINIK DR. NOR AZZAH \b0\par
No 138, (Tingkat Bawah) Jalan Melati 1,\par
Bandar Amanjaya, 08000, Sungai Petani\par
Kedah Darul Aman.\par
Tel/Fax 04-44330018\par
\pard\sl240\slmult1\qr\tab\tab\tab\tab\tab\tab\tab\tab\tab\f1\fs16 No MC: \cf2 --mc.no--\cf0\f0\par
\pard\sl240\slmult1\qc\b\fs32\par
SIJIL CUTI SAKIT\b0\fs24\par
\par
\par
\pard\sl240\slmult1\par
\pard\ri-1080\sl240\slmult1 Dengan ini disahkan bahawa saya telah merawat/memeriksa  Encik/Puan: \par
\ul --patient.name--\par
\ulnone dari\ul                                                                                                     ,\ulnone\par
didapati beliau tidak sihat untuk menjalankan tugas dengan sempurna \par
selama ........ hari, daripada \ul --treatment.date--\ulnone   hingga  \ul --treatment.date--\ulnone\par
\par
\par
Diagnosis\par
\par
\par
\par
\par
Tarikh \ul --treatment.date--\ulnone   \par
(NOT FOR COURT USE)\par
\pard\fi4320\ri-1080\sl240\slmult1\qc _____________________\par
Tandatangan Doktor\par
--doctor.name--\par
\pard\ri-1080\sl240\slmult1\highlight0\lang9\fs22\par
}
 ', N'MC', N'MC1')
INSERT [dbo].[metadata] ([value_], [type_], [name_]) VALUES (N'{\rtf1\ansi\ansicpg1252\deff0\deflang17417\deflangfe17417{\fonttbl{\f0\froman\fprq2\fcharset0 Times New Roman;}{\f1\fmodern\fprq1\fcharset0 Consolas;}}
{\colortbl ;\red255\green255\blue255;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\nowidctlpar\sl276\slmult1\qc\lang9\f0\fs48 KLINIK DR. NOR AZZAH\par
\fs22 No.138, (Tkt Bawah) Jln Melati 1\par
Bandar Amanjaya, 08000 Sungai Petani, Kedah Darul Aman.\par
No. Tel. : 04-4430018\par
\fs40\par
\fs20\par
\pard\nowidctlpar\sl276\slmult1\fs22 Date :  --current.date--\par
To :\par
\par
Re : \highlight1\ul\f1\fs19 --patient.name--\highlight0\ulnone\f0\fs22\par
I/C No.: \highlight1\ul\f1\fs19 --patient.ic--\highlight0\ulnone\f0\fs22\par
Age : --patient.age--\par
\fs20\par
\ul\fs24 May I refer this patient.\par
\ulnone\fs22 Symptoms:\par
\highlight1\f1\fs19 --symtomps.list--\highlight0\f0\fs22\par
\par
Signs :\par
\highlight1\f1\fs19 --signs.list--\highlight0\f0\fs22\par
\par
Diagnosis :\par
\highlight1\lang17417\f1\fs19 --diagnosis.list\highlight0 --\lang9\f0\fs22\par
\par
Treatment/Plan :\par
\fs20\par
\par
Thank You.\par
\par
Your Sincerely.\par
--dr.name--\par
}
 ', N'MC', N'REFER LETTER')
INSERT [dbo].[metadata] ([value_], [type_], [name_]) VALUES (N'{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}{\f1\fnil\fcharset0 Calibri;}}
{\*\generator Riched20 6.3.9600}\viewkind4\uc1 
\pard\sl276\slmult1\qc\f0\fs48\lang9 KLINIK DR. NOR AZZAH\par
\fs22 No.138, (Tkt Bawah) Jln Melati 1\par
Bandar Amanjaya, 08000 Sungai Petani, Kedah Darul Aman.\par
No. Tel. : 04-4430018\par

\pard\sl276\slmult1\f1\par
Tarikh : \ul --current.date--\ulnone\par
\par

\pard\sl360\slmult1 Kepada : ..........................................................................................................\par
\tab   ..........................................................................................................\par
\par
Tuan/Puan.\par
Adalah dimakumkan Bahawa Encik/Puan/Cik \par
\ul --patient.name--\par
\ulnone I/C  \ul --patient.ic-- \ulnone telah datang untuk rawatan pada tarikh \ul --treatment.date--\par
\ulnone Mulai jam \ul --treatment.starttime--\ulnone   sehingga \ul --treatment.endtime--\ulnone  .\par
Sekian,\par
Terima Kasih.\par
\par
.....................................................\par
--doctor.name--\par
Tanda Tangan Doktor.\par

\pard\sl276\slmult1\par
}
', N'MC', N'TIME SLIP')
