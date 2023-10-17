<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="terms-conditions.aspx.cs" Inherits="terms_conditions" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
     <style>
        #Termsandconditions i{font-size:15px !important;margin:0 15px 0 0;}
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Terms & conditions</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Terms & conditions</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- Terms & conditions Starts -->
     <span class="space50"></span>
    <section id="Termsandconditions"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">Terms and Conditions</h2>
      <span class="space30"></span>
         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Introduction</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">
             Welcome to <span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) </span>
             <span class="space10"></span>
             These Terms of Service (“Terms”, “Terms of Service”) govern your use of our website located at https://www.vtccdelhi.org (together or individually “Service”) operated by <span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) .</span>
         </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Our Privacy Policy also governs your use of our Service and explains how we collect, safeguard and disclose information that results from your use of our web pages. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Your agreement with us includes these Terms and our Privacy Policy (“Agreements”). You acknowledge that you have read and understood Agreements, and agree to be bound of them. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">If you do not agree with (or cannot comply with) Agreements, then you may not use the Service, but please let us know by emailing at vtccdelhi@gmail.com so we can try to find a solution. These Terms apply to all visitors, users and others who wish to access or use Service.</p>
         <span class="greyLine"></span>

          <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> Communications</p> 
          <p class="clrDarkGrey regular fontRegular mrg_B_20">By using our Service, you agree to subscribe to newsletters, marketing or promotional materials and other information we may send. However, you may opt out of receiving any, or all, of these communications from us by following the unsubscribe link or by emailing at vtccdelhi@gmail.com. </p>   
          <span class="greyLine"></span>

          <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> Contests, Sweepstakes and Promotions</p> 
          <p class="clrDarkGrey regular fontRegular mrg_B_20">Any contests, sweepstakes or other promotions (collectively, “Promotions”) made available through Service may be governed by rules that are separate from these Terms of Service. If you participate in any Promotions, please review the applicable rules as well as our Privacy Policy. If the rules for a Promotion conflict with these Terms of Service, Promotion rules will apply. </p>   
          <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Content</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Our Service allows you to post, link, store, share and otherwise make available certain information, text, graphics, videos, or other material (“Content”). You are responsible for Content that you post on or through Service, including its legality, reliability, and appropriateness. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">By posting Content on or through Service, You represent and warrant that: (i) Content is yours (you own it) and/or you have the right to use it and the right to grant us the rights and license as provided in these Terms, and (ii) that the posting of your Content on or through Service does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person or entity. We reserve the right to terminate the account of anyone found to be infringing on a copyright. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You retain any and all of your rights to any Content you submit, post or display on or through Service and you are responsible for protecting those rights. We take no responsibility and assume no liability for Content you or any third party posts on or through Service. However, by posting Content using Service you grant us the right and license to use, modify, publicly perform, publicly display, reproduce, and distribute such Content on and through Service.  </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You agree that this license includes the right for us to make your Content available to other users of Service, who may also use your Content subject to these Terms. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) </span>has the right but not the obligation to monitor and edit all Content provided by users.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">In addition, Content found on or through this Service are the property of <span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)  </span>or used with permission. You may not distribute, modify, transmit, reuse, download, repost, copy, or use said Content, whether in whole or in part, for commercial purposes or for personal gain, without express advance written permission from us.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Prohibited Uses</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You may use Service only for lawful purposes and in accordance with Terms. You agree not to use Service: </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">1. In any way that violates any applicable national or international law or regulation. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">2. For the purpose of exploiting, harming, or attempting to exploit or harm minors in any way by exposing them to inappropriate content or otherwise. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">3. To transmit, or procure the sending of, any advertising or promotional material, including any “junk mail”, “chain letter,” “spam,” or any other similar solicitation.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">4. To impersonate or attempt to impersonate Company, a Company employee, another user, or any other person or entity. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">5. In any way that infringes upon the rights of others, or in any way is illegal, threatening, fraudulent, or harmful, or in connection with any unlawful, illegal, fraudulent, or harmful purpose or activity. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">6. To engage in any other conduct that restricts or inhibits anyone’s use or enjoyment of Service, or which, as determined by us, may harm or offend Company or users of Service or expose them to liability. </p>

         <p class="clrDarkGrey fontMedium semiMedium mrg_B_20">Additionally, you agree not to: </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">1. Use Service in any manner that could disable, overburden, damage, or impair Service or interfere with any other party’s use of Service, including their ability to engage in real time activities through Service. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">2. Use any robot, spider, or other automatic device, process, or means to access Service for any purpose, including monitoring or copying any of the material on Service. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">3. Use any manual process to monitor or copy any of the material on Service or for any other unauthorized purpose without our prior written consent. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">4. Use any device, software, or routine that interferes with the proper working of Service. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">5. Introduce any viruses, trojan horses, worms, logic bombs, or other material which is malicious or technologically harmful. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">6. Attempt to gain unauthorized access to, interfere with, damage, or disrupt any parts of Service, the server on which Service is stored, or any server, computer, or database connected to Service. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">7. Attack Service via a denial-of-service attack or a distributed denial-of-service attack. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">8. Take any action that may damage or falsify Company rating. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">9. Otherwise attempt to interfere with the proper working of Service. </p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> Analytics</p> 
          <p class="clrDarkGrey regular fontRegular mrg_B_20">We may use third-party Service Providers to monitor and analyze the use of our Service. </p>
          <span class="greyLine"></span>

          <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> No Use By Minors</p> 
          <p class="clrDarkGrey regular fontRegular mrg_B_20">Service is intended only for access and use by individuals at least eighteen (18) years old. By accessing or using Service, you warrant and represent that you are at least eighteen (18) years of age and with the full authority, right, and capacity to enter into this agreement and abide by all of the terms and conditions of Terms. If you are not at least eighteen (18) years old, you are prohibited from both the access and usage of Service. </p>
          <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Intellectual Property</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Service and its original content (excluding Content provided by users), features and functionality are and will remain the exclusive property of <span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) </span>and its licensors. Service is protected by copyright, trademark, and other laws of and foreign countries. Our trademarks may not be used in connection with any product or service without the prior written consent of <span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) </span></p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Copyright Policy</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We respect the intellectual property rights of others. It is our policy to respond to any claim that Content posted on Service infringes on the copyright or other intellectual property rights (“Infringement”) of any person or entity.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">If you are a copyright owner, or authorized on behalf of one, and you believe that the copyrighted work has been copied in a way that constitutes copyright infringement, please submit your claim via email to vtccdelhi@gmail.com, with the subject line: “Copyright Infringement” and include in your claim a detailed description of the alleged Infringement as detailed below, under “DMCA Notice and Procedure for Copyright Infringement Claims”</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You may be held accountable for damages (including costs and attorneys’ fees) for misrepresentation or bad-faith claims on the infringement of any Content found on and/or through Service on your copyright.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> DMCA Notice and Procedure for Copyright Infringement Claims</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You may submit a notification pursuant to the Digital Millennium Copyright Act (DMCA) by providing our Copyright Agent with the following information in writing (see 17 U.S.C 512(c)(3) for further detail):</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">1. an electronic or physical signature of the person authorized to act on behalf of the owner of the copyright’s interest;</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">2. a description of the copyrighted work that you claim has been infringed, including the URL (i.e., web page address) of the location where the copyrighted work exists or a copy of the copyrighted work;</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">3. identification of the URL or other specific location on Service where the material that you claim is infringing is located;</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">4. your address, telephone number, and email address;</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">5. a statement by you that you have a good faith belief that the disputed use is not authorized by the copyright owner, its agent, or the law; 0.6. a statement by you, made under penalty of perjury, that the above information in your notice is accurate and that you are the copyright owner or authorized to act on the copyright owner’s behalf. You can contact our Copyright Agent via email at vtccdelhi@gmail.com</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Error Reporting and Feedback</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You may provide us either directly at vtccdelhi@gmail.com or via third party sites and tools with information and feedback concerning errors, suggestions for improvements, ideas, problems, complaints, and other matters related to our Service (“Feedback”).</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You acknowledge and agree that: (i) you shall not retain, acquire or assert any intellectual property right or other right, title or interest in or to the Feedback; (ii) Company may have development ideas similar to the Feedback; (iii) Feedback does not contain confidential information or proprietary information from you or any third party; and (iv) Company is not under any obligation of confidentiality with respect to the Feedback.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">In the event the transfer of the ownership to the Feedback is not possible due to applicable mandatory laws, you grant Company and its affiliates an exclusive, transferable, irrevocable, free-of-charge, sub-licensable, unlimited and perpetual right to use (including copy, modify, create derivative works, publish, distribute and commercialize) Feedback in any manner and for any purpose</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Links To Other Web Sites</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Our Service may contain links to third party web sites or services that are not owned or controlled by<span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)  </span> </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)  </span>has no control over, and assumes no responsibility for the content, privacy policies, or practices of any third party web sites or services. We do not warrant the offerings of any of these entities/individuals or their websites.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">For example, the outlined Terms of Use have been created using PolicyMaker.io, a free web application for generating high-quality legal documents. PolicyMaker’s Terms and Conditions generator is an easy-to-use free tool for creating an excellent standard Terms of Service template for a website, blog, e-commerce store or app.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">You acknowledge and agree that company shall not be responsible or liable, directly or indirectly, for any damage or loss caused or alleged to be caused by or in connection with use of or reliance on any such content, goods or services available on or through any such third party web sites or services.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We strongly advise you to read the terms of service and privacy policies of any third party web sites or services that you visit</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Disclaimer Of Warranty</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">These services are provided by company on an “as is” and “as available” basis. Company makes no representations or warranties of any kind, express or implied, as to the operation of their services, or the information, content or materials included therein. You expressly agree that your use of these services, their content, and any services or items obtained from us is at your sole risk.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Neither company nor any person associated with company makes any warranty or representation with respect to the completeness, security, reliability, quality, accuracy, or availability of the services. Without limiting the foregoing, neither company nor anyone associated with company represents or warrants that the services, their content, or any services or items obtained through the services will be accurate, reliable, error-free, or uninterrupted, that defects will be corrected, that the services or the server that makes it available are free of viruses or other harmful components or that the services or any services or items obtained through the services will otherwise meet your needs or expectations.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Company hereby disclaims all warranties of any kind, whether express or implied, statutory, or otherwise, including but not limited to any warranties of merchantability, non-infringement, and fitness for particular purpose.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">The foregoing does not affect any warranties which cannot be excluded or limited under applicable law.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Limitation of Liability</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Except as prohibited by law, you will hold us and our officers, directors, employees, and agents harmless for any indirect, punitive, special, incidental, or consequential damage, however it arises (including attorneys’ fees and all related costs and expenses of litigation and arbitration, or at trial or on appeal, if any, whether or not litigation or arbitration is instituted), whether in an action of contract, negligence, or other tortious action, or arising out of or in connection with this agreement.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Including without limitation any claim for personal injury or property damage, arising from this agreement and any violation by you of any federal, state, or local laws, statutes, rules, or regulations, even if company has been previously advised of the possibility of such damage. Except as prohibited by law, if there is liability found on the part of company, it will be limited to the amount paid for the products and/or services, and under no circumstances will there be consequential or punitive damages.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Some states do not allow the exclusion or limitation of punitive, incidental or consequential damages, so the prior limitation or exclusion may not apply to you.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Termination</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We may terminate or suspend your account and bar access to Service immediately, without prior notice or liability, under our sole discretion, for any reason whatsoever and without limitation, including but not limited to a breach of Terms.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">If you wish to terminate your account, you may simply discontinue using Service.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">All provisions of Terms which by their nature should survive termination shall survive termination, including, without limitation, ownership provisions, warranty disclaimers, indemnity and limitations of liability.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Governing Law</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">These Terms shall be governed and construed in accordance with the laws of India, which governing law applies to agreement without regard to its conflict of law provisions.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Our failure to enforce any right or provision of these Terms will not be considered a waiver of those rights. If any provision of these Terms is held to be invalid or unenforceable by a court, the remaining provisions of these Terms will remain in effect. These Terms constitute the entire agreement between us regarding our Service and supersede and replace any prior agreements we might have had between us regarding Service.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Changes To Service</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We reserve the right to withdraw or amend our Service, and any service or material we provide via Service, in our sole discretion without notice. We will not be liable if for any reason all or any part of Service is unavailable at any time or for any period. From time to time, we may restrict access to some parts of Service, or the entire Service, to users, including registered users.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Amendments To Terms</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">We may amend Terms at any time by posting the amended terms on this site. It is your responsibility to review these Terms periodically.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Your continued use of the Platform following the posting of revised Terms means that you accept and agree to the changes. You are expected to check this page frequently so you are aware of any changes, as they are binding on you.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">By continuing to access or use our Service after any revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, you are no longer authorized to use Service.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Waiver And Severability</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">No waiver by Company of any term or condition set forth in Terms shall be deemed a further or continuing waiver of such term or condition or a waiver of any other term or condition, and any failure of Company to assert a right or provision under Terms shall not constitute a waiver of such right or provision.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">If any provision of Terms is held by a court or other tribunal of competent jurisdiction to be invalid, illegal or unenforceable for any reason, such provision shall be eliminated or limited to the minimum extent such that the remaining provisions of Terms will continue in full force and effect.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">By continuing to access or use our Service after any revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, you are no longer authorized to use Service.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Acknowledgement</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">By using service or other services provided by us, you acknowledge that you have read these terms of service and agree to be bound by them.</p>
         <span class="greyLine"></span>

         <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> Contact Us</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">Please send your feedback, comments, and requests for technical support by email: vtccdelhi@gmail.com.</p>
     </div>
</asp:Content>

