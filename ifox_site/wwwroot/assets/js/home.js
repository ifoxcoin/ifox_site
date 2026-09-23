(function () {
    'use strict';

    document.addEventListener('DOMContentLoaded', function () {
        var globe = document.getElementById('ifox-globe');
        var reduced = window.matchMedia && window.matchMedia('(prefers-reduced-motion: reduce)').matches;

        if (globe && !('ontouchstart' in window) && !reduced) {
            window.addEventListener('mousemove', function (e) {
                var x = (e.clientX - window.innerWidth / 2) / (window.innerWidth / 2);
                var y = (e.clientY - window.innerHeight / 2) / (window.innerHeight / 2);
                globe.style.transform = 'translate3d(' + (x * 6) + 'px,' + (y * 4) + 'px,0)';
            });
        }

        var revealDefinitions = [
            { selector: '#clients', children: '.swiper-slide' },
            { selector: '#about', children: '.engineered-about__intro, .engineered-about__value' },
            { selector: '.ifox-business-choice', children: '.ifox-business-choice__heading, .ifox-business-choice__item' },
            { selector: '.ifox-technology-forward', children: '.ifox-technology-forward__heading, .ifox-technology-forward__item' },
            { selector: '.ifox-industry-forward', children: '.ifox-industry-forward__heading, .ifox-industry-forward__item' },
            { selector: '.ifox-digital-enterprise', children: '.ifox-digital-enterprise__heading, .ifox-digital-enterprise__item' },
            { selector: '#call-to-action', children: '.row' },
            { selector: '.service-map', children: '.section-title, .service-container' },
            { selector: '#skills', children: '.section-title, .row' },
            { selector: '#journey', children: 'h3, p, .mt-4' },
            { selector: '.ifox-final-cta', children: 'h2, p, .ifox-final-cta__actions' }
        ];

        var revealSections = [];

        revealDefinitions.forEach(function (definition) {
            document.querySelectorAll(definition.selector).forEach(function (section) {
                section.classList.add('home-scroll-reveal');
                section.querySelectorAll(definition.children).forEach(function (child, index) {
                    child.classList.add('home-scroll-reveal-child');
                    child.style.setProperty('--home-reveal-delay', Math.min(index, 5) * 140 + 'ms');
                });
                revealSections.push(section);
            });
        });

        if (reduced) {
            revealSections.forEach(function (section) {
                section.classList.add('home-scroll-reveal-visible');
            });
            return;
        }

        if (!('IntersectionObserver' in window)) {
            revealSections.forEach(function (section) {
                section.classList.add('home-scroll-reveal-visible');
            });
            return;
        }

        var observer = new IntersectionObserver(function (entries) {
            entries.forEach(function (entry) {
                if (!entry.isIntersecting) {
                    return;
                }

                entry.target.classList.add('home-scroll-reveal-visible');
                observer.unobserve(entry.target);
            });
        }, {
            rootMargin: '0px 0px -8% 0px',
            threshold: 0.12
        });

        revealSections.forEach(function (section) {
            observer.observe(section);
        });
    });
})();
