<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta content="IE=edge" http-equiv="X-UA-Compatible" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />

    <title>VTCC Education</title>

    <meta name="description" content="" />

    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap" rel="stylesheet" />

    <link href="css/EnglishMtsts.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <script src="js/jquery-2.2.4.min.js"></script>

    <link href="css/jquery.fancybox.css" rel="stylesheet" />
    <script src="js/jquery.fancybox.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/slick.js"></script>

   <%-- <!-- Add these in your <head> section -->
    <link rel="stylesheet" href="path/to/bootstrap.min.css"/>
    <script src="path/to/jquery.min.js"></script>
    <script src="path/to/bootstrap.min.js"></script>--%>


    <style>
        .qaimg {
            width: 153px;
        }

        .gradeimg {
            width: 140px
        }

        /*Revel Scroll animation*/
        /*   .reveal {position: relative; transform: translateY(150px); opacity: 0; transition: all 2s ease;}
            .reveal.activate {transform: translateY(0px); opacity: 1;}*/
    </style>

    <%-- Tost Notifications --%>
    
    <link href="css/toastr.css" rel="stylesheet" />
    <script src="js/toastr.js"></script>

    <script type="text/javascript">
        function TostTrigger(EventName, MsgText) {
            // code to be executed
            Command: toastr[EventName](MsgText)
            toastr.options = {
                "closeButton": true,
                "debug": false,
                "newestOnTop": false,
                "progressBar": false,
                "positionClass": "toast-top-full-width",
                "preventDuplicates": false,
                "onclick": null,
                "showDuration": "300",
                "hideDuration": "1000",
                "timeOut": "5000",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "slideDown",
                "hideMethod": "fadeOut"
            }

        }
    </script>

</head>
<body>
    <div class="">
        <div class="">
            <div class="">
                <a href="https://wa.me/917498503730?text=I%20AM%20INTERESTED%20IN%20VOCATIONAL%20TRAINING%20%26%20CERTIFICATION%0ACOMMITTEE%20(VTCC)%2C%20NEW%20DELHI%2C%20INDIA%E2%80%99S%20ATC%20AFFILIATION.%20PLEASE%20SEND%20ME%20PROPOSAL%0A" class="whatsappLink" target="_blank" title="Contact us on Whatsapp"></a>
            </div>

             <div class="">
                <a href="#" class="payonline" title="Make Online Payment"></a>
            </div>
        </div>
    </div>
    <form id="form1" runat="server">
        <header id="header">
            <div class="topLine"></div>
            <div class="container-fluid position-relative">
                <div class="p-2">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <div id="logo" class="text-center">
                                <style>
                                    #logo {
                                        margin-top: 20px;
                                    }
                                </style>
                                <a href="<%= rootPath %>" title="">
                                   <img src="<%=rootPath +"images/vtcc-logo.png"%>" alt="" title="" /></a>
                                <span class="space5"></span>
                               <%-- <span class="small bold">हुनर है तो रोजगार है</span>--%>
                            </div>
                        </div>
                        <div class="col-md-7 col-lg-7">
                            <div class="logoName">
                                <p class="d-block small headtxt" style="line-height:1.5">
                                    Accredited certification body by A+ Rating from QUALITY ASSURANCE AND<br />ACCREDITATION COMMITTEE (QAAC), NEW DELHI, INDIA. & an ISO 9001:2015 <br />certification by Emirates International Accreditation Centre (EIAC), Governmental Accreditation <br />Body Dubai & International Accreditation Service (I.A.S.) U.S.A.
                                </p>
                               
                                <span class=" themeClrPrime fontRegular">
                                    (A NATIONAL.  COMMITTEE UNDER INDIAN ACT 1882, N.C.T. OF DELHI, GOVERNMENT OF INDIA)
                                    <br />
                                    (Registration Number - 847/2022-2023/B-4/VOL.No 4742
                                </span>
                                 <span class="space5"></span>
                                <h1 class=" themeClrPrime semiBold large"> VOCATIONAL TRAINING  &amp; CERTIFICATION 
                                <br />
                                    COMMITTEE (VTCC), NEW DELHI, INDIA</h1>

                                 <span class="space15"></span>
                                <h1 class="themeClrPrime semiBold medium">व्यावसायिक प्रशिक्षण एवम् प्रमाणन समिति, नई दिल्ली, भारत</h1>
                            </div>
                        </div>
                        <div id="icons">
                            <div class="col-md-3 d-inline">
                                <img src= "<%=rootPath +"images/icons/grade-plus-1.png"%>" class="img-fluid gradeimg" />
                                <img src="<%=rootPath +"images/icons/QAAc-new.png"%>" class="img-fluid qaimg"/>
                                
                                <span class="space10"></span>
                                <%--<div class="fontRegular regular text-center lgtext text-uppercase">A+ Rating BY (QAAC), NEW DELHI, India</div>--%>
                            </div>
                        </div>
                    </div>
                 </div>
                    <div class="float_clear"></div>
                </div>
                <a id="navBtn" onclick="openNav()"></a>
            <%--</div>--%>
            <!-- Navigation Starts -->
            <nav id="topNavPanel">
                <div class="container-fluid">
                    <ul id="topNav">
                        <a href="javascript:void(0)" class="closeBtn" onclick="closeNav()">&times;</a>
                        <li><a href="<%= rootPath %>">Home</a></li>
                        <li class="list">
                            <a class="subNav">VTCC</a>
                            <ul class="items">
                                <li><a href= "<%=rootPath +"about-us" %>">Our Profile</a></li>
                                <li><a href="<%=rootPath +"courses"%>">Courses Information</a></li>
                                <li><a href="<%=rootPath +"news"%>">Latest News</a></li>
                                <li><a href="<%=rootPath +"#"%>">VTCC Tie-ups</a></li>
                            </ul>
                        </li>
                        <li><a href="<%=rootPath +"Affiliation-centers"%>">VTCC ATC Affiliation</a></li>
                        <li><a href="<%=rootPath +"training-centers"%>">Exam Centers</a></li>
                        <li><a href="<%=rootPath +"#"%>" <%--target="_blank"--%>>Online Exams</a></li>
                        <li class="list">
                            <a class="subNav">Registration</a>
                            <ul class="items">
                                <li><a href="<%=rootPath +"center-registration"%>">ATC Registration</a></li>
                                <li><a href="<%=rootPath+"atc-renewal"%>">ATC Renewal Process</a></li>
                            </ul>
                        </li>
                        <li class="list">
                            <a class="subNav" href="<%=rootPath +"#"%>" <%--target="_blank"--%>>Verification</a>
                            <ul class="items">
                                 <li><a href="<%=rootPath +"#"%>" <%--target="_blank"--%>>Student Certificate Verification</a></li>
                            </ul>
                        </li>

                        <li><a href="<%=rootPath +"document-download"%>">Downloads</a></li>
                        <li><a href="<%=rootPath +"other-products"%>" class="bgnav">VTCC Other Products</a></li>
                    </ul>
                    <!--<div class="float_clear"></div>-->
                    <div id="mobNav" class="text-left">
                        <span class="space20"></span>
                        <div class="pad_30 txtLeft">
                            <span class="tiny upperCase clrWhite letter-sp-3 mrg_B_15">Phone:</span>
                            <span class="space1"></span>
                            <a href="#" class="clrWhite"><span class="fa fa-phone"></span><span class="clrWhite">+91 9975327900</span></a>
                            <span class="space40"></span>
                            <span class="tiny upperCase clrWhite letter-sp-3 mrg_B_15">Email:</span>
                            <span class="space1"></span>
                            <a href="#" class="clrWhite"><span class="fa fa-envelope"></span><span class="clrWhite">info&#64;mtsts&#46;org</span></a>
                        </div>
                    </div>
                </div>
            </nav>
            <!-- Navigation Ends -->
        </header>
        <!-- start banner Area -->
        <section class="banner-area relative" id="home">
            <div class="overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-9 col-md-12">
                            <h2 class="text-uppercase letter-sp-2 xx-large text-white">We Ensure better education
                            for a better world
                            </h2>
                            <p class="pt-10 pb-10 text-light">
                                A Society Woking for Industry sector for providing self-employment training to the Students and Job seekers.
                            </p>
                            <a href="affiliation-centers" class="primary-btn text-uppercase letter-sp-2">Get Started</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End banner Area -->

        <!-- Start feature Area -->
        <span class="space20"></span>
        <section class="feature-area">
            <span class="space30"></span> 
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-6 col-sm-6 ">
                        <div class="bg-white Services">
                            <div class="title1">
                                <div class="p-2">
                                    <span class="space10"></span>
                                    <span class="semiMedium semiBold clrWhite">Courses We Offer</span>
                                 <span class="space10"></span> 
                                </div>                              
                            </div>                            
                                 <div class="p-3">
                                <div class="absIcon">
                                    <%--<img src="images/icons/courses.png" />--%>
                                </div>
                                <p class="fontMedium">
                                    <span class="space10"></span> 
                                    Get to know more details of courses
                                </p>
                                <a href="courses">Know More</a>
                                </div>                           
                        </div>
                    </div>
                    
                    <div class="col-lg-3 col-md-6 col-sm-6 ">
                        <div class="bg-white Services">
                            <div class="title1">                               
                                <div class="p-2">
                                    <span class="space10"></span>
                                    <span class="semiMedium semiBold clrWhite">Sample Certificates</span>                                                          
                                    <span class="space10"></span> 
                                </div>
                                 
                            </div>
                             <div class="p-3">
                                <div class="absIcon">
                                    <%--<img src="images/icons/certificate.png" />--%>
                                </div>
                                <p class="fontMedium">
                                    <span class="space10"></span> 
                                    Get Our Sample
                                    <br />
                                    Certificates
                                </p>
                                <a href="sample-certificates">Know More</a>
                           </div>
                        </div>
                    </div>


                    <div class="col-lg-3 col-md-6 col-sm-6 ">
                        <div class="bg-white Services">
                            <div class="title1">
                                <div class="p-2">
                                    <span class="space10"></span>
                                    <span class="semiMedium semiBold clrWhite">Final Online Exam</span>                                                                                    
                                 <span class="space10"></span> 
                                </div>                               
                            </div>
                              <div class="p-3">
                                <div class="absIcon">
                                    <%--<img src="images/icons/online-exam.png" />--%>
                                </div>
                                <p class="fontMedium">
                                    <span class="space10"></span> 
                                     Test your preparation with Online Examination
                                </p>
                                <a href="#" <%--target="_blank""--%>>Know More</a>
                             </div>
                        </div>
                    </div>

                     <div class="col-lg-3 col-md-6 col-sm-6 ">
                        <div class="bg-white Services">
                            <div class="title1">
                                <div class="p-2">
                                    <span class="space10"></span>
                                    <span class="semiMedium semiBold clrWhite">Download Proposal</span>                                                                                                                       
                                 <span class="space10"></span> 
                                </div>
                                
                            </div>
                            <div class="p-3">
                                <div class="absIcon">
                                    <%--<img src="images/icons/download.png" />--%>
                                </div>
                                <p class="fontMedium">
                                    <span class="space10"></span> 
                                    Get your franchisee proposal now !
                                </p>
                                <a href="download-proposal">Know More</a>
                            </div>
                        </div>
                    </div>

                   
                </div>
            </div>
        </section>
        <!-- End feature Area -->

        <!-- About us Starts -->
        <span class="space50"></span>
        <section id="about" class="">
                <div class="container pt-30">
                    <div class="row d-flex justify-content-center">
                        <div class="col-lg-3">
                            <a href="images/quality-a-certificate.png" data-fancybox="imggroup">
                                <img src="images/vtcc-quality-assurance-and-accreditation.jpg" class="img-fluid" /></a>
                        </div>
                        <div class="menu-content col-lg-9">
                            <span class="space40"></span>
                            <div class="title">
                                <h2 class="mb-30 themeClrPrime fontMedium">VTCC Welcomes You !</h2>
                            </div>
                            <p class="pb-20 line-ht-8"><strong class="semiBold">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC), </strong> has played a significant role in technical/vocational education and certification. The VTCC started conducting Examinations of the students sponsored by the Affiliated Institutions at various centers all over India. These examinations have gained immense popularity in India and abroad. </p>
                            <a href="about-us" class="primary-btn text-uppercase letter-sp-2">Read More</a>
                        </div>
                    </div>
                </div>
        </section>
        <span class="space80"></span>
        <!-- About us Ends -->
        <!-- Start center reg -->
        <section class="search-course-area relative reveal">
            <div class="overlay overlay-bg"></div>
            <div class="container">
                <div class="row justify-content-between align-items-center">
                    <div class="col-lg-6 col-md-6 search-course-left">
                        <h3 class="text-white fontMedium">VTCC Learning
                            <br/>
                            Center Registration!
                        </h3>
                        <p>
                            Register your institute / center here now, to be a part of VTCC.
                            <br />
                            Use below link to register your center / institute.
                        </p>
                        <a href="center-registration" class="primary-btn upperCase letter-sp-2">Register Now</a>
                        <div class="row details-content">
                            <div class="col single-detials">
                                <span class="fa fa-graduation-cap"></span>
                                <a href="#"> <%--target="_blank"--%>
                                    <h4 class="medium fontMedium">Verify Students Certificate</h4>
                                </a>
                                <p>
                                    Just Add Certificate Number and View your VTCC Certificate
                                </p>
                            </div>
                            <div class="col single-detials">
                                <span class="fa fa-id-card"></span>
                                <a href="sample-certificates">
                                    <h4 class="medium fontMedium">Certification</h4>
                                    <span class="space10"></span>
                                </a>
                                <p>
                                    Here have our several certificates patterns
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6 search-course-right section-gap">
                        <h4 class="text-white pb-20 text-center mb-30 pt-30 fontMedium">VTCC ATC <br /> Authorized Login</h4>
                        <div class="form-wrap">
                            <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter Username" onfocus="this.placeholder = ''" onblur="this.placeholder = 'User Name'"></asp:TextBox>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="primary-btn text-uppercase letter-sp-2" OnClick="btnLogin_Click" />
                            <span class="space30"></span>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End center reg -->

        <%--new why us--%>
        <span class="space50"></span>
        <section id="whyus" class="why-choose-us">
            <div class="container text-center">
                    <h2>Why Choose VTCC?</h2>
                    <p>VTCC Learning Center can help students to improve their communication skills, as well as enhance their thinking ability. It also helps them to increase their knowledge and learn real-life applications.</p>
               <span class="space20"></span> 
                <%-- Why choose icon box --%>
            <div class="row justify-content-center">              
                <div class="col-xl-4 col-lg-6 col-md-6 d-flex align-items-stretch">
                     <div class="feature">
                    <div class="icon-box mt-4 mt-xl-0">
                   
                        <img src="images/icons/briefcase.png" alt=" "/>
                         <span class="space10"></span>
                        <h4>Job Openings</h4>  
                        <span class="space10"></span>
                        <p>Our experienced team is dedicated to delivering top-notch solutions tailored to your needs.</p>
                        <%-- <span class="space20"></span>--%>
                        <a href="job-openings" class="more-btn d-inline-block letter-sp-2 upperCase fontMedium">View More</a>
                         <img src="images/icons/right-arrow4.png" alt=" "/>
                    </div>
                     </div>
                </div>
                

                 <div class="col-xl-4 col-lg-6 col-md-6 d-flex align-items-stretch">
                      <div class="feature">
                    <div class="icon-box mt-4 mt-xl-0">                       
                        <img src="images/icons/group 1.png" alt=" "/>
                        <span class="space10"></span>
                        <h4>Placed Students</h4>  
                        <span class="space10"></span>
                        <p>We offer competitive pricing without compromising on quality and service.</p>
                        <span class="space20"></span>
                        <a href="placed-students" class="more-btn d-inline-block letter-sp-2 upperCase fontMedium">View More</a>
                         <img src="images/icons/right-arrow4.png" alt=" "/>
                    </div>
                      </div>
                </div>

                 <div class="col-xl-4 col-lg-6 col-md-6 d-flex align-items-stretch">
                      <div class="feature">
                    <div class="icon-box mt-4 mt-xl-0">
                        <img src="images/icons/career-activity.png" alt=" "/>
                        <span class="space10"></span>
                        <h4>Career Activities</h4>  
                        <span class="space10"></span>
                         <p>Customer satisfaction is our priority, and we strive to exceed your expectations.</p>
                        <span class="space20"></span>
                         <a href="career-activities"  class="more-btn d-inline-block letter-sp-2 upperCase fontMedium">View More</a>
                          <img src="images/icons/right-arrow4.png" alt=" "/>
                    </div>
                      </div>
                </div>
            </div>
                 <div class="text-center pt-40">
                    <a href="about-us" class="primary-btn text-uppercase letter-sp-2">Learn More</a>

                </div>

            <%-- Why choose icon box end--%>
               </div>
        </section>
       

        <!-- Why Us Ends-->

        <!-- Start news -->
        <%=nwsstr %>
        <%-- <span class="space30"></span>
        <section class="blog-area" id="blog">--%>
        
       <%--     <div class="container">
                <div class="row d-flex justify-content-center">
                    <div class="menu-content pb-50 col-lg-8">
                        <div class="title text-center">
                            <h3 class="xx-large themeClrPrime">Latest News</h3>
                              <span class="space10"></span>
                        </div>
                    </div>
                </div>--%>

               <%-- slider news --%>

                 
               <%--<div id="carouselExample" class="carousel slide">
                      
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div class="row featurette d-flex justify-content-center align-items-center">
                                    <div class="col-md-7">
                                        <p class="meta ">25 April, 2023  |  By <a href="#">Mark Wiens</a></p>
                                        <h2 class="featurette-heading fw-normal lh-1 medium themeClrPrime">News Information</h2>
                                         <span class="space10"></span>
                                         <p class="fontRegular">
                                            Students get information about various topics with the help of newspaper. They become a good orator which further helps in taking active part in debates,
                                        
                                          
                                        </p>
                                    </div>
                                    <div class="col-md-5">
                                        <img class="img-fluid" src="images/news-img.jpg" alt=""/>
                                    </div>
                                </div>
                        </div>--%>
                      <%--  <div class="carousel-item">
                            <div class="row featurette d-flex justify-content-center align-items-center">
                                    <div class="col-md-7">
                                        <p class="meta">25 April, 2023  |  By <a href="#">Mark Wiens</a></p>
                                        <h2 class="featurette-heading fw-normal lh-1 medium themeClrPrime">News Article</h2>
                                         <span class="space10"></span>
                                         <p class="fontRegular">
                                            Regardless of the type of news article you're writing, it should always include the facts of the story, a catchy but informative headline, a summary of events in paragraph form, 
                                            and interview quotes from expert sources or of public sentiment about the event. 
                                          
                                        </p>
                                    </div>
                                    <div class="col-md-5">
                                        <img class="img-fluid" src="images/news-img2.jpg" alt=""/>
                                    </div>
                                </div>
                        </div>--%>
                       <%-- <div class="carousel-item">
                            <div class="row featurette d-flex justify-content-center align-items-center">
                                    <div class="col-md-7">
                                        <p class="meta">25 April, 2023  |  By <a href="#">Mark Wiens</a></p>
                                        <h2 class="featurette-heading fw-normal lh-1 medium themeClrPrime">Newspaper Report </h2>
                                         <span class="space10"></span>
                                         <p class="fontRegular">
                                           A newspaper report is a news story found in newspapers and are designed to provide people with information about what is happening in the world.
                                           News is new information and is usually about something that has just happened. 
                                          
                                        </p>
                                    </div>
                                    <div class="col-md-5">
                                        <img class="img-fluid" src="images/news-img3.jpg" alt=""/>
                                    </div>
                                </div>
                        </div>
                    </div>--%>
                  <%--  <button class="" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                         <img class="img-fluid" src="images/icons/prev2.png" alt=""/>
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                      </button>
                    <button class="" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                        <img class="img-fluid" src="images/icons/next3.png" alt=""/>
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                       </button>
                </div>--%>

              <%-- <div class="text-center pt-40">
                  <a href="news" class="primary-btn text-uppercase letter-sp-2">More News</a>
                  </div>            
            </div>
        </section>--%>
       <%-- <span class="space35"></span>--%>
        <!-- End blog Area news -->

        <!-- logo slider Starts -->
    <div class="width100" id="doctors">
        <span class="space40"></span>
        <div class="col_1140 txtCenter">
         
            <section class="doc-profile slider">
                <div class="slide"><img src="images/icons/grade-plus-1.png" class="width100 img-fluid " style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/about-us/EIAC blue logo.JPG" class="width100 img-fluid mt-5 "style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/about-us/1540948016IAS_H_CMYK_HIRES.png" class="width100 img-fluid mt-5" style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/about-us/iaf-logo-w256.png" class="width100 img-fluid mt-4" style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/about-us/NCS logo.png"  class="width100 img-fluid mt-4" style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/about-us/NITI-AYOG-NGO-DARPAN.jpg" class="width100" style="width:140px"/><span class="space5"></span></div>
                <div class="slide"><img src="images/icons/QAAc-new.png" class="width100" style="width:140px"/><span class="space5"></span></div>
             
                </section>
                </div>
        <span class="space40"></span>
    </div>
<!-- logo slider Ends -->

        <!-- Footer Starts -->
        <footer id="footer">
            <div class="footer-top">
                <div class="container">
                    <div class="row">

                   
                        <div class="col-lg-3 col-md-6 footer-links">
                            <h4>Useful Links</h4>
                            <ul>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%= rootPath %>">Home</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"about-us"%>">About us</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"courses"%>">Courses Information</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"news"%>">Latest News</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"contact-us"%>">Contact Us</a></li>
                            </ul>
                        </div>
                        <div class="col-lg-3 col-md-6 footer-links">
                            <h4>Quick Links</h4>
                            <ul>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"Affiliation-centers"%>">VTCC ATC Affiliation</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"training-centers"%>">Exam Centers</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"#"%>" <%--target="_blank"--%>>Online Exam</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"sample-certificates"%>">Certification</a></li>
                                 <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"other-products"%>">VTCC Other Products</a></li>
                            </ul>
                        </div>
                        <div class="col-lg-3 col-md-6 footer-links">
                            <h4>Other Links</h4>
                            <ul>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"faq"%>">FAQ </a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"disclaimer"%>">Disclaimer</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"terms-services"%>" >Terms Of Services</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"privacy-policy"%>">Privacy Policy</a></li>
                                 <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"terms-conditions"%>">Terms & Conditions</a></li>
                            </ul>
                        </div>
                        <div class="col-lg-3 col-md-6 footer-links">
                            <h4>Other Links</h4>
                            <ul>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"#"%>">Authorised Institute </a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"download-proposal"%>">Franchaise Agreement</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"online-payment"%>">Make Online Payment</a></li>
                                <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"center-registration"%>">Online Franchaise Form</a></li>
                                 <li><i class="fa fa-angle-right"></i>&nbsp;<a href="<%=rootPath +"career-activities"%>">Gallery</a></li>
                            </ul>
                        </div>
                        <div class="col-12 text-center">
                             <h4 class="fontMedium">Administration Office for Maharashtra</h4>
                             <span class="fontMedium">Vocational Training and Certification Committee,New Delhi,India</span>
                            <p>
                                <span class="fontRegular">Sangeet Ratna Abdul Karim Kha Smruti Bhavan, Shivaji Road, In 
                                   Front of Priyadarshini Hotel, Miraj, Tal-Miraj, Dist-Sangli, Maharashtra-416410
                              
                                </span>
                                <span class="space10"></span>
                                <strong>Phone:</strong> <a href="#" class=""><span class="fa fa-phone"></span><span class="mrg_R_15"> 7498503730</span></a>
                                <strong>Email:</strong> <a href="#" class="">vtccdelhi&#64;gmail&#46;com</a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row justify-content-md-between pt-15 pb-10">
                    <div class="col-md-6">
                        <div class="copyright">
                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script>
                            <strong><span class="semiBold">VTCC</span></strong>. All Rights Reserved
                        </div>
                        <div class="credits">Designed by <a href="http://www.intellect-systems.com/">Intellect Systems</a></div>
                    </div>
                    <div class="col-md-6 social-links text-md-right pt-3 pt-md-0">
                        <a href="#"><i class="fa fa-facebook"></i></a>
                        <a href="#"><i class="fa fa-twitter"></i></a>
                        <a href="#"><i class="fa fa-instagram"></i></a>
                        <a href="#"><i class="fa fa-youtube"></i></a>
                        <a href="#"><i class="fa fa-linkedin"></i></a>
                    </div>
                </div>
            </div>
            
        </footer>
        <span class="space40"></span>

        <!-- Footer Ends-->
        <%--urget contact start--%>
        <div class="bgsrtip enquirystrip">
            <div class="container text-center">
                 <span class="space10"></span>
                <span class="semiBold regular clrWhite">For more information whatsapp message on - 7498503730 | or mail us on vtccdelhi@gmail.com</span>
            <span class="space10"></span>
            </div>
        </div>
        <%--urget contact end--%>
    </form>


      <%-- Scroll Animation Script --%>
 <%--   <script>
        function reveal() {
            //alert("function called")
            var reveals = document.querySelectorAll(".reveal");
            for (var i = 0; i < reveals.length; i++) {
                var windowHeight = window.innerHeight;
                var elementTop = reveals[i].getBoundingClientRect().top;
                var elementVisible = 150;
                if (elementTop < windowHeight - elementVisible) {
                    reveals[i].classList.add("activate");
                } else {
                    reveals[i].classList.remove("activate");
                }
            }
        }
        function loaded() {
            //alert("function loaded");
            var reveals = document.querySelectorAll(".reveal");
            for (var i = 0; i < reveals.length; i++) {
                var windowHeight = window.innerHeight;
                var elementTop = reveals[i].getBoundingClientRect().top;
                var elementVisible = 150;
                if (elementTop < windowHeight - elementVisible) {
                    reveals[i].classList.add("activate");
                } else {
                    reveals[i].classList.remove("activate");
                }
            }
            //alert("function load end");
        }
        window.addEventListener("scroll", reveal);
        window.addEventListener("load", loaded);
    </script>--%>

    <script type="text/javascript">
        function openNav() {
            //alert("demo");
            document.getElementById("topNavPanel").style.width = "320px";
            document.getElementById("navBtn").style.zIndex = "0";
        }
        function closeNav() {
            document.getElementById("topNavPanel").style.width = "0";
            document.getElementById("navBtn").style.zIndex = "5";
        }
    </script>
    <script>
        const list = document.querySelectorAll('.list');

        function accordion(e) {
            e.stopPropagation();
            if (this.classList.contains('active')) {
                this.classList.remove('active');
            }
            else if (this.parentElement.parentElement.classList.contains('active')) {
                this.classList.add('active');
            }
            else {
                for (i = 0; i < list.length; i++) {
                    list[i].classList.remove('active');
                }
                this.classList.add('active');
            }
        }
        for (i = 0; i < list.length; i++) {
            list[i].addEventListener('click', accordion);
        }

    </script>
     <script type="text/javascript">
         $(document).ready(function () {
             //$('.topNews').slick({
             //    slidesToShow: 2, slidesToScroll: 1, autoplay: true, autoplaySpeed: 2000, arrows: false, dots: false, pauseOnHover: true,
             //    responsive: [{ breakpoint: 656, settings: { slidesToShow: 1 } }]
             //});

             $('.doc-profile').slick({
                 slidesToShow: 6, slidesToScroll: 1, autoplay: true, autoplaySpeed: 2000, arrows: false, dots: false, pauseOnHover: true,
                 responsive: [{ breakpoint: 876, settings: { slidesToShow: 4 } }, { breakpoint: 656, settings: { slidesToShow: 3 } }, { breakpoint: 496, settings: { slidesToShow: 2 } }, { breakpoint: 376, settings: { slidesToShow: 1 } }]
             });
         });
     </script>


  

</body>
</html>
