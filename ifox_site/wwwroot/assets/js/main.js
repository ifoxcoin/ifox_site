/**
* Template Name: Arsha
* Updated: Mar 10 2023 with Bootstrap v5.2.3
* Template URL: https://bootstrapmade.com/arsha-free-bootstrap-html-template-corporate/
* Author: BootstrapMade.com
* License: https://bootstrapmade.com/license/
*/
(function () {
    "use strict";

    /**
     * Easy selector helper function
     */
    const select = (el, all = false) => {
        el = el.trim()
        if (all) {
            return [...document.querySelectorAll(el)]
        } else {
            return document.querySelector(el)
        }
    }

    /**
     * Easy event listener function
     */
    const on = (type, el, listener, all = false) => {
        let selectEl = select(el, all)
        if (selectEl) {
            if (all) {
                selectEl.forEach(e => e.addEventListener(type, listener))
            } else {
                selectEl.addEventListener(type, listener)
            }
        }
    }

    /**
     * Easy on scroll event listener 
     */
    const onscroll = (el, listener) => {
        el.addEventListener('scroll', listener)
    }

    /**
     * Navbar links active state on scroll
     */
    let navbarlinks = select('#navbar .scrollto', true)
    const navbarlinksActive = () => {
        let position = window.scrollY + 200
        navbarlinks.forEach(navbarlink => {
            if (!navbarlink.hash) return
            let section = select(navbarlink.hash)
            if (!section) return
            if (position >= section.offsetTop && position <= (section.offsetTop + section.offsetHeight)) {
                navbarlink.classList.add('active')
            } else {
                navbarlink.classList.remove('active')
            }
        })
    }
    window.addEventListener('load', navbarlinksActive)
    onscroll(document, navbarlinksActive)

    /**
     * Scrolls to an element with header offset
     */
    const scrollto = (el) => {
        let header = select('#header')
        let offset = header.offsetHeight

        let elementPos = select(el).offsetTop
        window.scrollTo({
            top: elementPos - offset,
            behavior: 'smooth'
        })
    }

    /**
     * Toggle .header-scrolled class to #header when page is scrolled
     */
    let selectHeader = select('#header')
    if (selectHeader) {
        const headerScrolled = () => {
            if (window.scrollY > 100) {
                selectHeader.classList.add('header-scrolled')
            } else {
                selectHeader.classList.remove('header-scrolled')
            }
        }
        window.addEventListener('load', headerScrolled)
        onscroll(document, headerScrolled)
    }

    /**
     * Back to top button
     */
    document.addEventListener("DOMContentLoaded", function () {

        const backToTop = document.querySelector(".back-to-top");

        if (!backToTop) {
            console.log("Back-to-top button not found");
            return;
        }

        // Show / hide button while scrolling
        window.addEventListener("scroll", function () {
            if (window.scrollY > 100) {
                backToTop.classList.add("active");
            } else {
                backToTop.classList.remove("active");
            }
        });

        // Scroll to top when clicked
        backToTop.addEventListener("click", function (event) {
            event.preventDefault();

            window.scrollTo({
                top: 0,
                left: 0,
                behavior: "smooth"
            });
        });

    });

    /**
     * Mobile nav toggle
     */
    on('click', '.mobile-nav-toggle', function (e) {
        select('#navbar').classList.toggle('navbar-mobile')
        this.classList.toggle('bi-list')
        this.classList.toggle('bi-x')
    })

    /**
     * Mobile nav dropdowns activate
     */
    on('click', '.navbar .dropdown > a', function (e) {
        if (select('#navbar').classList.contains('navbar-mobile')) {
            e.preventDefault()
            this.nextElementSibling.classList.toggle('dropdown-active')
        }
    }, true)

    /**
     * Scrool with ofset on links with a class name .scrollto
     */
    on('click', '.scrollto', function (e) {
        if (select(this.hash)) {
            e.preventDefault()

            let navbar = select('#navbar')
            if (navbar.classList.contains('navbar-mobile')) {
                navbar.classList.remove('navbar-mobile')
                let navbarToggle = select('.mobile-nav-toggle')
                navbarToggle.classList.toggle('bi-list')
                navbarToggle.classList.toggle('bi-x')
            }
            scrollto(this.hash)
        }
    }, true)

    /**
     * Scroll with ofset on page load with hash links in the url
     */
    window.addEventListener('load', () => {
        if (window.location.hash) {
            if (select(window.location.hash)) {
                scrollto(window.location.hash)
            }
        }
    });

    /**
     * Preloader
     */
    let preloader = select('#preloader');
    if (preloader) {
        window.addEventListener('load', () => {
            preloader.remove()
        });
    }

    /**
     * Initiate  glightbox 
     */
    const glightbox = GLightbox({
        selector: '.glightbox'
    });

    /**
     * Skills animation
     */
    let skilsContent = select('.skills-content');
    if (skilsContent) {
        new Waypoint({
            element: skilsContent,
            offset: '80%',
            handler: function (direction) {
                let progress = select('.progress .progress-bar', true);
                progress.forEach((el) => {
                    el.style.width = el.getAttribute('aria-valuenow') + '%'
                });
            }
        })
    }

    /**
     * Porfolio isotope and filter
     */
    window.addEventListener('load', () => {
        let portfolioContainer = select('.portfolio-container');
        if (portfolioContainer) {
            let portfolioIsotope = new Isotope(portfolioContainer, {
                itemSelector: '.portfolio-item'
            });

            let portfolioFilters = select('#portfolio-flters li', true);

            on('click', '#portfolio-flters li', function (e) {
                e.preventDefault();
                portfolioFilters.forEach(function (el) {
                    el.classList.remove('filter-active');
                });
                this.classList.add('filter-active');

                portfolioIsotope.arrange({
                    filter: this.getAttribute('data-filter')
                });
                portfolioIsotope.on('arrangeComplete', function () {
                    AOS.refresh()
                });
            }, true);
        }

    });

    /**
     * Initiate portfolio lightbox 
     */
    const portfolioLightbox = GLightbox({
        selector: '.portfolio-lightbox'
    });

    /**
     * Portfolio details slider
     */
    new Swiper('.portfolio-details-slider', {
        speed: 400,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false
        },
        pagination: {
            el: '.swiper-pagination',
            type: 'bullets',
            clickable: true
        }
    });

    /**
     * Animation on scroll
     */
    window.addEventListener('load', () => {
        AOS.init({
            duration: 1000,
            easing: "ease-in-out",
            once: true,
            mirror: false
        });
    });

    /* ================= CHATBOT APP ENGINE ================= */

    let step = "welcome";
    let userEmail = "";
    let navStack = [];   // ⭐ navigation history
    let clientStep = "";
    /* ===== CHAT TRACKING ===== */
    let chatHistory = [];
    let startTracking = false;
    let idleTimer;
    let transcriptSent = false;
    const CHAT_IDLE_MS = 60000; // 60 sec


    /* ⭐ AUTO SCROLL FUNCTIONS */
    function scrollToElement(el) {
        setTimeout(() => {
            el.scrollIntoView({ behavior: "smooth", block: "start" });
        }, 150);
    }

    function scrollBottom() {
        const box = document.getElementById("chatbot-messages");
        box.scrollTop = box.scrollHeight;
    }

    function pushHistory(fnName) {
        navStack.push(fnName);
    }

    /* ================= INIT ================= */

    document.addEventListener("DOMContentLoaded", function () {

        const toggleBtn = document.getElementById("chatbot-toggle");
        const chatBox = document.getElementById("chatbot-box");
        const closeBtn = document.getElementById("chatbot-close");
        const backBtn = document.getElementById("chatbot-back");
        const sendBtn = document.getElementById("chatbot-send");
        const input = document.getElementById("chatbot-input");
        const messages = document.getElementById("chatbot-messages");
        const buttons = document.getElementById("chatbot-buttons");

        let isOpen = false;
        /* OPEN CHAT */
        toggleBtn.onclick = () => {
            chatBox.style.display = isOpen ? "none" : "flex";
            isOpen = !isOpen;

            if (step === "welcome") {
                bot("Hi 👋 Welcome to iFox!\n\nI can help you with services, hiring, or Dynamics 365 CRM.");
                bot("First, may I have your work email to continue?");
                step = "askEmail";
            }
        }
        closeBtn.onclick = () => chatBox.style.display = "none";

        /* ================= BACK BUTTON (REAL HISTORY) ================= */
        backBtn.onclick = () => {

            if (navStack.length <= 1) {
                navStack = [];
                showMainMenu(true);
                return;
            }

            navStack.pop();                 // remove current
            const previous = navStack.pop();// get previous
            window[previous](true);         // open previous without chat message
        }

        sendBtn.onclick = sendMessage;
        input.addEventListener("keypress", e => { if (e.key === "Enter") sendMessage() });

        function sendMessage() {
            let msg = input.value.trim();
            if (!msg) return;
            user(msg);
            input.value = "";
            botFlow(msg.toLowerCase());
        }

        function bot(msg) {
            const div = document.createElement("div");
            div.className = "bot-msg";
            div.innerHTML = msg;
            messages.appendChild(div);
            scrollToElement(div);
            trackMessage("Bot", msg);
        }

        function user(msg) {
            const div = document.createElement("div");
            div.className = "user-msg";
            div.innerText = msg;
            messages.appendChild(div);
            scrollToElement(div);
            trackMessage("User", msg);
        }

        function clearBtns() { buttons.innerHTML = "" }

        function addBtns(arr) {
            clearBtns();
            arr.forEach(x => {
                buttons.innerHTML += `<button class="chat-btn" onclick="${x.fn}">${x.text}</button>`
            });
            scrollBottom();
        }

        /* ================= EMAIL FLOW ================= */

        function botFlow(msg) {

            if (step === "askEmail") {

                if (!msg.includes("@")) {
                    bot("Please enter valid email 😊");
                    return;
                }

                // save email
                userEmail = msg;

                // ⭐ START TRACKING FROM NOW
                startTracking = true;
                transcriptSent = false;
                chatHistory = [];

                // notify
                notifyWhatsApp("🔥 New chatbot visitor: " + userEmail);

                // ⭐ ADD THIS MESSAGE HERE
                bot("Thanks 😊\nHow can we help you today?");

                // open main menu
                showMainMenu();

                step = "menu";
                return;
            }

            // random questions
            bot("For more details contact us 👇");
            contactCTA();
        }

        /* ================= MAIN MENU ================= */

        window.showMainMenu = function (fromBack = false) {
            pushHistory("showMainMenu");

            addBtns([
                { text: "Client / Business", fn: "clientModule()" },
                { text: "Job Seekers", fn: "jobModule()" },
                { text: "Dynamic CRM", fn: "DynamicCRMModule()" },
                { text: "Support", fn: "supportModule()" }
            ]);
        }
        function trackMessage(sender, text) {

            if (!startTracking) return;

            chatHistory.push({
                sender: sender,
                text: text,
                time: new Date().toISOString()
            });

            resetIdleTimer();
        }


        /* ================= CLIENT MODULE ================= */

        window.clientModule = function (fromBack = false) {
            pushHistory("clientModule");
            if (!fromBack) user("Client / Business");

            // ⭐ Step 1 question
            bot("Great! Are you looking for a new project or support for an existing one?");

            // ⭐ show 3 buttons
            addBtns([
                { text: "New Project", fn: "clientNewProject()" },
                { text: "Existing Project Support", fn: "clientSupportProject()" },
                { text: "Just Exploring", fn: "clientExploring()" }
            ]);
        }
        /* ===== CLIENT STEP 2 ===== */

        window.clientNewProject = function () {
            user("New Project");
            bot("Awesome 🚀 Let's build something great together!");
            showClientServices();
        }

        window.clientSupportProject = function () {
            user("Existing Project Support");
            bot("Great 👍 We can support and improve your current system.");
            showClientServices();
        }

        window.clientExploring = function () {
            user("Just Exploring");
            bot("No problem 😊 Here are the services we offer.");
            showClientServices();
        }
        /* ===== CLIENT SERVICES BUTTONS ===== */

        function showClientServices(fromBack = false) {

            // ⭐ THIS IS THE FIX
            pushHistory("showClientServices");

            bot("What services are you interested in?");

            addBtns([
                { text: "Dynamics 365 Implementation", fn: "d365Impl()" },
                { text: "CRM Migration", fn: "migration()" },
                { text: "CRM Integration", fn: "integration()" },
                { text: "Dedicated Developers", fn: "dedicatedDev()" },
                { text: "Project Pricing", fn: "pricing()" }
            ]);
        }



        window.d365Impl = function () {
            pushHistory("clientModule");
            user("Dynamics 365 Implementation");
            bot("We implement end-to-end Dynamics 365 CRM solutions.");
            bot("• Sales • Customer Service \n • Marketing • Field Service \n • Power Platform");
            askProjectTimeline();
        }

        window.migration = function () {
            pushHistory("clientModule");
            user("CRM Migration");
            bot("We migrate CRM from:");
            bot("• On-premise → Cloud • Salesforce → Dynamics • Legacy → Dynamics");
            askProjectTimeline();
        }

        window.integration = function () {
            pushHistory("clientModule");
            user("CRM Integration");
            bot("We integrate Dynamics with ERP, SharePoint, Azure & Power BI.");
            askProjectTimeline();
        }

        window.pricing = function () {
            pushHistory("clientModule");
            user("Pricing");
            bot("Typical cost: $3k – $20k+ depending on scope.");
            askProjectTimeline();
        }
        window.dedicatedDev = function () {
            pushHistory("showClientServices");
            user("Dedicated Developers");
            bot("Hire skilled developers for your project on monthly basis.");
            bot("We provide .NET, Dynamics 365, React & Full-stack developers.");
            askProjectTimeline();
        }

        /* ================= JOB SEEKER MODULE ================= */

        window.jobModule = function (fromBack = false) {
            pushHistory("jobModule");
            if (!fromBack) user("Job Seekers");

            bot("Great! What type of role are you looking for?");

            addBtns([
                { text: "Dynamics 365 CRM Developer", fn: "jobCRM()" },
                { text: ".NET Developer", fn: "jobDotnet()" },
                { text: "Frontend Developer", fn: "jobFrontend()" },
                { text: "UI/UX Designer", fn: "jobUIUX()" },
                { text: "QA / Testing", fn: "jobQA()" },
                { text: "Internship", fn: "jobIntern()" }
            ]);
        }


        /* ===== ROLE CLICK → ASK EXPERIENCE ===== */

        function askExperience() {
            pushHistory("askExperience");

            bot("How many years of experience do you have?");

            addBtns([
                { text: "Fresher", fn: "expFresher()" },
                { text: "1–3 years", fn: "exp1to3()" },
                { text: "3–5 years", fn: "exp3to5()" },
                { text: "5+ years", fn: "exp5plus()" }
            ]);
        }


        /* ===== ROLE FUNCTIONS ===== */

        window.jobCRM = function () {
            pushHistory("jobModule");
            user("Dynamics 365 CRM Developer");
            askExperience();
        }

        window.jobDotnet = function () {
            pushHistory("jobModule");
            user(".NET Developer");
            askExperience();
        }

        window.jobFrontend = function () {
            pushHistory("jobModule");
            user("Frontend Developer");
            askExperience();
        }

        window.jobUIUX = function () {
            pushHistory("jobModule");
            user("UI/UX Designer");
            askExperience();
        }

        window.jobQA = function () {
            pushHistory("jobModule");
            user("QA / Testing");
            askExperience();
        }

        window.jobIntern = function () {
            pushHistory("jobModule");
            user("Internship");
            askResume();
        }


        /* ===== EXPERIENCE → ASK WORK TYPE ===== */

        function askWorkType() {
            pushHistory("askWorkType");

            bot("Preferred work type?");

            addBtns([
                { text: "Remote", fn: "workRemote()" },
                { text: "Hybrid", fn: "workHybrid()" },
                { text: "Onsite", fn: "workOnsite()" }
            ]);
        }


        /* ===== EXPERIENCE BUTTON FUNCTIONS ===== */

        window.expFresher = function () { user("Fresher"); askWorkType(); }
        window.exp1to3 = function () { user("1–3 years"); askWorkType(); }
        window.exp3to5 = function () { user("3–5 years"); askWorkType(); }
        window.exp5plus = function () { user("5+ years"); askWorkType(); }


        /* ===== WORK TYPE → RESUME STEP ===== */

        function askResume() {
            pushHistory("askResume");

            bot("Please upload your resume or share LinkedIn profile link through E-Mail");
            contactCTA(); // final step
        }


        /* ===== WORK TYPE BUTTON FUNCTIONS ===== */

        window.workRemote = function () { user("Remote"); askResume(); }
        window.workHybrid = function () { user("Hybrid"); askResume(); }
        window.workOnsite = function () { user("Onsite"); askResume(); }


        /* =========================================================
           DYNAMICS 365 CRM SPECIAL FUNNEL – FINAL (SIMPLIFIED)
        ========================================================= */

        window.DynamicCRMModule = function (fromBack = false) {
            pushHistory("DynamicCRMModule");
            if (!fromBack) user("Dynamics 365 CRM");

            bot("Are you already using Dynamics 365?");

            addBtns([
                { text: "Yes", fn: "crmYes()" },
                { text: "No, planning to start", fn: "crmPlanning()" },
                { text: "Migrating from another CRM", fn: "crmMigrating()" }
            ]);
        }


        /* =========================================================
           IF USER ALREADY USING CRM
        ========================================================= */

        window.crmYes = function () {
            pushHistory("crmYes");
            user("Yes");

            bot("What do you need help with?");

            addBtns([
                { text: "Customization", fn: "crmFinal()" },
                { text: "Integration", fn: "crmFinal()" },
                { text: "Automation", fn: "crmFinal()" },
                { text: "Performance Issues", fn: "crmFinal()" },
                { text: "Support & Maintenance", fn: "crmFinal()" },
                { text: "Power Platform / Copilot", fn: "crmFinal()" }
            ]);
        }


        /* =========================================================
           IF USER PLANNING TO START CRM
        ========================================================= */

        window.crmPlanning = function () {
            pushHistory("crmPlanning");
            user("Planning to start");

            bot("Which Dynamics 365 module are you interested in?");

            addBtns([
                { text: "Sales", fn: "crmFinal()" },
                { text: "Customer Service", fn: "crmFinal()" },
                { text: "Marketing", fn: "crmFinal()" },
                { text: "Field Service", fn: "crmFinal()" },
                { text: "Finance & Operations", fn: "crmFinal()" },
                { text: "Not sure", fn: "crmFinal()" }
            ]);
        }


        /* =========================================================
           IF USER MIGRATING FROM OTHER CRM
        ========================================================= */

        window.crmMigrating = function () {
            pushHistory("crmMigrating");
            user("Migrating from another CRM");

            bot("We help migrate from Salesforce, Zoho, HubSpot and legacy CRMs.");
            crmFinal();
        }


        /* =========================================================
           FINAL STEP → CONTACT CTA
        ========================================================= */

        window.crmFinal = function () {
            user("Details selected");
            bot("Perfect! Our Dynamics 365 experts will contact you shortly.");
            contactCTA();
        }



        /* ================= SUPPORT ================= */

        window.supportModule = function (fromBack = false) {
            pushHistory("supportModule");
            if (!fromBack) user("Support");

            bot("24/7 Dynamics CRM support available.");
            contactCTA();
        }

        /* ================= CONTACT CTA ================= */

        window.contactCTA = function () {
            bot("For more details contact us 👇 \n Contact:+919488718218 \n E-Mail:hr@ifox.co.in");

            buttons.innerHTML = `
        <a class="chat-btn" target="_blank"
        href="https://wa.me/919488718218">Chat on WhatsApp</a>

        <div style="margin:8px;font-size:12px;">OR</div>

        <a class="chat-btn" target="_blank"
        href="mailto:hr@ifox.co.in?subject=Website Enquiry">
        Send Email</a>`;
        }
        function resetIdleTimer() {
            clearTimeout(idleTimer);

            idleTimer = setTimeout(() => {
                if (!transcriptSent) {
                    sendChatToEmail();
                    transcriptSent = true;
                }
            }, CHAT_IDLE_MS);
        }
        async function sendChatToEmail() {

            if (!userEmail || chatHistory.length === 0) return;

            try {
                await fetch("/api/chat/send-transcript", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: JSON.stringify({
                        userEmail: userEmail,
                        messages: chatHistory
                    })
                });

                console.log("Transcript sent");
            } catch (e) {
                console.error("Transcript failed", e);
            }
        }
        /* ===== PROJECT TIMELINE STEP ===== */

        function askProjectTimeline() {

            // history save (back button working)
            pushHistory("askProjectTimeline");

            bot("When are you planning to start?");

            addBtns([
                { text: "Immediately", fn: "timelineImmediate()" },
                { text: "1–3 months", fn: "timeline1to3()" },
                { text: "3–6 months", fn: "timeline3to6()" },
                { text: "Just researching", fn: "timelineResearch()" }
            ]);
        }
        window.timelineImmediate = function () {
            user("Immediately");
            bot("Great! Our team can start right away 🚀");
            contactCTA();
        }

        window.timeline1to3 = function () {
            user("1–3 months");
            bot("Perfect 👍 We can plan and prepare the project.");
            contactCTA();
        }

        window.timeline3to6 = function () {
            user("3–6 months");
            bot("Sounds good 😊 We can schedule the roadmap.");
            contactCTA();
        }

        window.timelineResearch = function () {
            user("Just researching");
            bot("No problem! We're happy to guide you.");
            contactCTA();
        }


        /* ================= WHATSAPP ALERT ================= */

        function notifyWhatsApp(message) {

            fetch("https://carisa-triangular-unpreventively.ngrok-free.dev/notify", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    email: userEmail,
                    message: message
                })
            })
                .then(res => res.text())
                .then(data => console.log("WhatsApp Notified"))
                .catch(err => console.error("Error sending WhatsApp:", err));
        }

        /*Hover Effect*/

            const dot = document.getElementById('cursor-dot');
            const ring = document.getElementById('cursor-ring');

            let mouseX = 0;
            let mouseY = 0;

            let ringX = 0;
            let ringY = 0;

            document.addEventListener('mousemove', function (e) {

                mouseX = e.clientX;
            mouseY = e.clientY;

            dot.style.left = mouseX + 'px';
            dot.style.top = mouseY + 'px';

        });

            function animateCursor() {

                ringX += (mouseX - ringX) * 0.15;
            ringY += (mouseY - ringY) * 0.15;

            ring.style.left = ringX + 'px';
            ring.style.top = ringY + 'px';

            requestAnimationFrame(animateCursor);
        }

            animateCursor();

        /* Hover Effect */

        document.querySelectorAll('a,button').forEach(el => {

                el.addEventListener('mouseenter', () => {

                    ring.style.width = '55px';
                    ring.style.height = '55px';

                    ring.style.borderColor = 'rgba(0,245,255,.6)';

                });

            el.addEventListener('mouseleave', () => {

                ring.style.width = '36px';
            ring.style.height = '36px';

            ring.style.borderColor = 'rgba(0,245,255,.6)';

            });

        });
        console.log("LAYOUT LOADED");



        /* ─── NAV SMOOTH SCROLL ─── */
        document.querySelectorAll('a[href^="#"]').forEach(a => {
            a.addEventListener('click', e => {
                e.preventDefault();
                const target = document.querySelector(a.getAttribute('href'));
                if (target) gsap.to(window, { duration: 1.2, scrollTo: target, ease: 'power3.inOut' });
            });
        });

        /* ─── CLICK RIPPLE EFFECT ─── */
        document.addEventListener('click', e => {
            if (e.target.tagName === 'CANVAS') return;
            const ripple = document.createElement('div');
            Object.assign(ripple.style, {
                position: 'fixed',
                left: e.clientX + 'px', top: e.clientY + 'px',
                width: '4px', height: '4px',
                borderRadius: '50%',
                background: 'rgba(0,245,255,0.6)',
                boxShadow: '0 0 20px rgba(0,245,255,0.4)',
                transform: 'translate(-50%,-50%) scale(1)',
                pointerEvents: 'none',
                zIndex: '9000',
                transition: 'transform 0.6s ease, opacity 0.6s ease'
            });
            document.body.appendChild(ripple);
            requestAnimationFrame(() => {
                ripple.style.transform = 'translate(-50%,-50%) scale(30)';
                ripple.style.opacity = '0';
            });
            setTimeout(() => ripple.remove(), 700);
        });
    });



})()