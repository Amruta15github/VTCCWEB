<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="about-us.aspx.cs" Inherits="about_us" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
    <style>
       #aboutus i{font-size:15px !important;margin:0 20px 0 0;}      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">About Us</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>About Us</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- about us Starts -->
    <span class="space50"></span>
    <section id="aboutus"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">ABOUT VTCC (INTRODUCTION) – </h2>
      <span class="space30"></span>
      <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">THE VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)</span>is the only certification Committee in India that is Accredited <span class="semiBold clrBlack">A+ Rating by QUALITY ASSURANCE AND ACCREDITATION COMMITTEE, NEW DELHI, INDIA (QAAC) (गुणवत्ता आश्वासन एवं प्रत्यायन समिति, नई दिल्ली, भारत . ) for providing quality services for students and training centers.</span></p>
      <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC), </span>has played a significant role in technical/vocational education and certification. The VTCC started conducting Examinations of the students sponsored by the Affiliated Institutions at various centers all over India. These examinations have gained immense popularity in India and abroad.</p>
      <p class="clrDarkGrey regular fontRegular mrg_B_20">The<span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC), </span>has designed updated business and skill development courses. It includes various skills and certification programs, e.g. diploma courses, workshop courses, participation training courses, and short-term courses, in any skills, educational, management, vocational, employment-oriented, technical, industrial, corporate etc. The syllabus for various vocational/technical / Professional Examinations is introduced and revised from time to time. VTCC & students' certificate designs for these Career oriented courses are issued and valid as per Government order of NES-EEM NO 1/2010/PT.I-VII/7 9, NO. DGE & T-M 27014/1/2009-EE.I, MINISTRY OF LABOUR & EMPLOYMENT, NEW DELHI, INDIA, and it's valid for private employment or industrial jobs .</p>
      <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">Get Your Courses Recognized: -  </span>In the VTCC Courses Recognition Program, VTCC assesses and recognizes your courses as conforming to the requirements of Global standards. Gaining recognition for your approach could increase your visibility and overall value if it becomes recognized by VTCC. Getting your course recognition is a perfect way to differentiate from your competition. After the VTCC course approval, ATC can start courses for their designed courses or syllabus.</p>
      <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="regular"><i class="fa fa-eye " aria-hidden="true"></i></span> OUR VISION :- </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We are going to recognize & certified affiliated institutes, non-governmental organizations, various computer training & vocational training institutes, colleges, other vocational training centers in different parts of India and abroad for affiliated under<span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)</span>in all over India for holding Examinations, certifying students for their skill training and awarding student certificates to successful students accordance with standards and Rules & Regulations laid down by the Committee. Generally, to do all acts, things and deeds that are incidental or conducive to attaining the aims and objects of the society. <span class="semiBold clrBlack">VTTC plays all important role as per our vision regarding </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10"><span class="semiBold clrBlack">Guidance to Vocational / Technical institutions.</span></p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Affiliation of Institutions in India and abroad. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Introduction and Revision of Syllabi.</p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Conduction of Examination. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Admission to Examinations.</p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Setting of Question Papers. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Appointment of the Examiners. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Appointment of the Expert Committees. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Appointment of the Examiners.  </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Allotment of Centers.  </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Conduct of Examinations. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Issue Certificates to students and affiliate centers. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Appointment of Board of Examinations. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Shields and Awards. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Publication of Bulletin. </p>
         <p class="regular semiBold mrg_B_5 mt-4 clrBlack"><span class="semiMedium"><i class="fa fa-angle-right " aria-hidden="true"></i></span>  Library facility. </p>     
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="regular"><i class="fa fa-users " aria-hidden="true"></i></span> EXPERT COMMITTEES :- </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)</span>established various expert committees for designing student qualification frameworks, preparing examination structures, evaluating skill training programs, taking exams, issuing certificates, appointing training centers and examination centers, evaluating students etc., for control assessment and certification work.</p>
     

         <p class="clrDarkGrey semiMedium mrg_B_20 "><span class="semiBold clrBlack">Board of Management</span></p>
         <span class="shortLine themeBgThr"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">The Board of Management of the<span class="semiBold clrBlack">VTCC </span>is the Principal Executive Body of the Institution. The Board of Management has the power of management and administration of the Institution and the conduct of all affairs of the Institution not otherwise provided for fulfilment of the objects of the Institution to make it an Institution of Excellence for promoting skill-based programmers in the field of Vocational training. </p>


         <p class="clrDarkGrey semiMedium mrg_B_20 "><span class="semiBold clrBlack">Advisory Board</span></p>
         <span class="shortLine themeBgThr"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">The Board of Management of the<span class="semiBold clrBlack">VTCC </span>is the Principal Executive Body of the Institution. The Board of Management has the power of management and administration of the Institution and the conduct of all affairs of the Institution not otherwise provided for fulfilment of the objects of the Institution to make it an Institution of Excellence for promoting skill-based programmers in the field of Vocational training. </p>


         <p class="clrDarkGrey semiMedium mrg_B_20 "><span class="semiBold clrBlack">Executive Council</span></p>
         <span class="shortLine themeBgThr"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Executive Council is the principal Council of the Institution to monitor & control the executive functions of the Institution. This Council assists the Board of Management in the discharge of many of its processes of Academic and Administrative nature to strengthen the Institution in all respects.</p>


         <p class="clrDarkGrey semiMedium mrg_B_20 "><span class="semiBold clrBlack">Academic Council</span></p>
         <span class="shortLine themeBgThr"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Academic Council exercises general supervision over the educational work of the Institution, methods of evaluation, research and improvement in academic standards. It lays down curriculum & frame syllabi for various programs offered by the Institution and promotes research activities and programs. It determines equivalence and improvement in the academic standards of the Institution.</p>


         <p class="clrDarkGrey semiMedium mrg_B_20 "><span class="semiBold clrBlack">Examination Council</span></p>
         <span class="shortLine themeBgThr"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Examination Council is the highest body for the conduct of Examinations. It lays down pre-examination, the actual behavior of examination & post-examination processes of Examinations. The Examination Council appoints Paper Setters, Moderators, Evaluators and Result Committees. It functions under the overall control of the Board of Management. It takes all measures to maintain the reliability, validity and credibility of the examinations conducted by the Institution.</p>
          <a href="#">Apply For Expert Committee Member </a>
         <span class="greyLine"></span>
         <%--Apply For Expert Committee Member:- ( Make an application form to apply as a committee member) Link form here.--%>
         

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><img src="images/icons/rgbvtcc1.jpg"  /> Additional activities/Schemes :- </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) </span>is inviting applications for the following Schemes and awards for students and training centers </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack"><i class=" fa fa-angle-right " aria-hidden="true"></i> STUDENT'S SCHOLARSHIP EXAMINATIONS NATIONAL LEVEL BRILLIANT STUDENT AWARDS</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack"><i class=" fa fa-angle-right " aria-hidden="true"></i> APPLICATIONS FOR EXPERT COMMITTEES MEMBER. </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack"><i class=" fa fa-angle-right " aria-hidden="true"></i> APPLICATIONS FOR NATIONAL LEVEL BEST TEACHER AWARDS </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack"><i class=" fa fa-angle-right " aria-hidden="true"></i>	APPLICATIONS FOR NATIONAL LEVEL BEST CENTER AWARDS </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack"><i class=" fa fa-angle-right " aria-hidden="true"></i>	APPLICATIONS FOR INNOVATIVE IDEAS IN TRAINING AND DEVELOPMENT</span></p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><img src="images/icons/accredited.png" /> VTCC ACCREDITATIONS :- </p>
         <img src="images/about-us/accri logo.jpg" class="img-fluid qaimg" />
         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">QUALITY ASSURANCE AND ACCREDITATION COMMITTEE, NEW DELHI, INDIA (QAAC) गुणवत्ता आश्वासन एवं प्रत्यायन समिति, नई दिल्ली, भारत </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">QUALITY ASSURANCE AND ACCREDITATION COMMITTEE, NEW DELHI, INDIA (QAAC) </span>is an independent, Assessment & Certification Agency & a National organization for recognized quality standard certification & various Accreditation. </p>
         <img src="images/vtcc-logo.png" class="mr-3" />
         <img src="images/icons/QAAc-new.png" class="img-fluid qaimg mr-3" />
         <img src="images/about-us/Avtcc-new.png"  />
        
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">VTCC</span> Accredited<span class="semiBold clrBlack"> A+</span> Rating by<span class="semiBold clrBlack"> AQUALITY ASSURANCE AND ACCREDITATION COMMITTEE, NEW DELHI, INDIA (QAAC) गुणवत्ता आश्वासन एवं प्रत्यायन समिति, नई दिल्ली, भारत . VTCC is the only certification body in India Accredited A+ by QAAC</span></p>
         <span class="greyLine"></span>

         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">NCT NEW DELHI, GOVERNMENT OF INDIA.</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30">NCT NEW DELHI, the government of India, is a government department for registering the various bodies/committees under sub registrar government of India.</p>
         <img src="images/about-us/delhi nct goverment logo.png" />
         <span class="space30"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">VTCC</span> Register under Indian Act, 1882 under NCT New Delhi, Government of India.<span class="semiBold clrBlack"> Registration Number - 847/2022-2023/B-4/VOL.No 4,742</span></p>
         <span class="greyLine"></span>

         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">EMIRATES INTERNATIONAL ACCREDITATION CENTRE (EIAC), GOVERNMENTAL ACCREDITATION BODY, DUBAI</span></p>
         <img src="images/vtcc-logo.png" class="mr-3"/>
         <img src="images/about-us/iaf-logo-w256.png" class="img-fluid qaimg mr-3" />
         <img src="images/about-us/EIAC blue logo.JPG" class="img-fluid qaimg" />
         <span class="space20"></span>
         <p class="certi  regular fontRegular mrg_B_20 "><span class="semiBold clrBlack">Certified Once, Accepted Everywhere</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">The IAF members represent the 83 government and semi-government accreditation bodies and industry associations. Emirates International Accreditation Centre (EIAC), The Emirates International Accreditation Centre (EIAC) (formerly Dubai Accreditation Department (DAC), is the official governmental accreditation body of Dubai.</p>        
         <li class="clrDarkGrey regular fontRegular">Emirates International Accreditation Centre (EIAC)</li>
         <li class="clrDarkGrey regular fontRegular"><span class="semiBold clrBlack">Emirates International Accreditation Centre (EIAC)</span></li>
         <li class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">International Accreditation Number - 22DQKP07</span></li>
         <span class="greyLine"></span>

         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">International Accreditation Service (IAS) USA</span></p>
         <p class="certi regular fontRegular mrg_B_20 "><span class="semiBold clrBlack">Certified Once, Accepted Everywhere</span></p>
         <img src="images/vtcc-logo.png" class="mr-3" />
         <img src="images/about-us/iaf-logo-w256.png" class="img-fluid qaimg mr-3" />
         <img src="images/about-us/1540948016IAS_H_CMYK_HIRES.png" class="img-fluid qaimg" />
         <span class="space20"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">The IAF members represent the 83 government and semi-government accreditation bodies and industry associations. IAS is a nonprofit, public-benefit corporation providing accreditation services since 1975. IAS accredits a wide range of companies and organizations</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">International Accreditation Service (IAS)<span class="semiBold clrDarkGrey"> International Accreditation Number - IS/2208VR/4795</span></span></p>
         <span class="greyLine"></span>
         
         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">NITI AAYOG GOVERNMENT OF INDIA</span></p>
         <img src="images/vtcc-logo.png" class="mr-3" />
         <img src="images/about-us/NITI-AYOG-NGO-DARPAN.jpg" class="img-fluid qaimg" />
         <span class="space20"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">The NGO-DARPAN platform provides space for the interface between VOs/NGOs and key Government Ministries / Departments / Government Bodies. Later it is proposed to cover all Central Ministries / Departments / Government Bodies. NITI Aayog Government of India maintains the NGO DARPAN.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">NITI Aayog Government of India <span class="semiBold clrDarkGrey"> NGO-DARPAN NITI Aayog Unique Id: MH/2022/0316790</span></span></p>
         <span class="greyLine"></span>

         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">PLACEMENT ORGANIZATION UNDER MINISTRY OF LABOUR AND EMPLOYMENT, GOVT. OF INDIA</span></p>
         <img src="images/vtcc-logo.png" />
         <img src="images/about-us/NCS logo.png"/>
         <img src="images/about-us/ncs logo hori.JPG"  />
         <span class="space20"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">National Career Service is a Five Year Mission Mode Project launched by the Hon’ble Prime Minister on 20th July 2015. The Directorate General of Employment, Ministry of Labour & Employment, is implementing the project. National Career Service (NCS) is a one-stop solution that provides a wide array of employment and career-related services to the citizens of India. It works towards bridging the gap between job seekers and employers, candidates seeking training and career guidance, and agencies providing training and career counselling.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10"><span class="semiBold clrBlack">Registered: NCS, Ministry Of Labour And Employment, Govt. Of India</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrDarkGrey"> Placement agency Registration No. P17G72-0939456991742</span></p>
         <span class="greyLine"></span>

         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">International Verification of VTCC certifications on </span></p>
         <p class="clrDarkGrey semiMedium mrg_B_30"><span class="semiBold themeClrThr">International Accreditation Forum (IAF) </span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10"><span class="semiBold clrBlack">IAF CertSearch has been established by the International Accreditation Forum and its members, so accredited certifications from around the world can be validated.</span> IAF CertSearch is a global database where users can search and validate the status of accredited certificates issued by a Certification Body, which an IAF signatory member Accreditation Body has accredited under the main scope ISO/IEC 17021-1.
          The IAF is the world association of Conformity Assessment Accreditation Bodies. The primary function of the IAF is to develop a single worldwide program of conformity assessment which reduces the risk for businesses and their customers by assuring them that accredited certificates may be relied upon. Accreditation assures users of the competence and impartiality of the accredited body. Conformity assessment is the demonstration that what is being supplied meets the requirements specified or claimed in an accreditation or certification. </p>
         <p class="text-center certi regular fontRegular mrg_B_20 "><span class="semiBold clrBlack">Certified Once, Accepted Everywhere</span></p>
         <div class="text-center">
         <img src="images/about-us/global-map.JPG" class="img-fluid border border-dark" />
         </div>
         
         <span class="space30"></span>
         <div class="text-center">
         <img src="images/about-us/iaf-logo-w256.png" class="img-fluid qaimg"  />
         <img src="images/about-us/IAS-Active.jpg" class="img-fluid qaimg"  />
         <%--<img src="images/about-us/IAS-Vaild-QR.jpg" class="mr-3" />
         <img src="images/about-us/Emirates-International-Accreditation-Centre-(EIAC)1.jpg" class="mr-3" />--%>
         <img src="images/vtcc-logo.png"/>
             </div>
         <span class="space30"></span>
        <%-- <p class=" clrBlack regular fontRegular mrg_B_10">International Verification Links :</p>
         <a href="https://www.iafcertsearch.org/certification/901dc646-96cd-5100-84cc-d024e90eb5e4">https://www.iafcertsearch.org/certification/901dc646-96cd-5100-84cc-d024e90eb5e4</a>
         <br />
         <a href="https://www.iafcertsearch.org/certification/9890cf82-0584-5317-9dee-d7ef2700a686">https://www.iafcertsearch.org/certification/9890cf82-0584-5317-9dee-d7ef2700a686</a>
         --%>
         <span class="greyLine"></span>

        <%-- <p class="clrDarkGrey semiMedium mrg_B_20"><span class="semiBold themeClrThr">Maharashtra Technical & Self Employment Training Society (MTSTS) for IIT Mumbai Courses.</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">VTCC did a tie-up with Maharashtra Technical & Self Employment Training Society (MTSTS) for IIT Mumbai AICTE-approved courses all over India.  MTSTS is An ISO 9001:2015 Certified society Associate Knowledge Partner of AICTE Approved IIT Bombay (National Mission on Education through ICT, Ministry of Education, Govt. of India) </p>
         <img src="images/vtcc-logo.png" class="mr-3"/>
         <img src="images/about-us/logo-mtsts.png" class="mr-3" />
         <img src="images/about-us/IIT Mumbai logo.png" class="img-fluid qaimg" />
         <span class="greyLine"></span>--%>

         <p class="clrDarkGrey semiMedium mrg_B_20"><span class="semiBold themeClrThr">UDYAM APPROVAL </span></p>
         <img src="images/about-us/msme logo.jpg" class="img-fluid" />
         <span class="space20"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">VTTC is working in support and guidance with Ministry of Micro, Small & Medium Enterprises (M/o MSME) Government of India. Small and medium-sized businesses are the backbone of the Indian economy. They contribute significantly to employment, economic growth, and innovation. However, these businesses often face various challenges such as lack of access to credit, delayed payments, and difficulty in marketing their products and services. To address these challenges, the Ministry of Micro, Small and Medium Enterprises (MSME) in India has launched a new online registration process known as Udyam registration. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30"><span class="semiBold clrBlack">Udyam Registration Number is - UDYAM-MH-29-0075426.</span></p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="regular"><i class="fa fa-check-circle " aria-hidden="true"></i></span> Approval / Recognitions :- </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"></p>
     
     </div>
</asp:Content>

