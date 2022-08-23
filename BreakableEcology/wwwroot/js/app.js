"use strict";

let lock = false;
let header;

window.scrollLock = () => {
    if (!lock) {
        let pagePosition = window.scrollY;
        document.body.style.position = 'fixed';
        document.body.dataset.position = pagePosition;
        document.body.style.top = - pagePosition + 'px';
        document.documentElement.style.scrollBehavior = 'auto';
        lock = true;
    }
}

window.scrollUnlock = ()=> {
    if (lock) {
        let pagePosition = parseInt(document.body.dataset.position, 10);
        document.body.style.position = '';
        document.body.style.top = '';
        window.scrollTo({
            top: pagePosition,
            behavior: "auto"
        });
        document.documentElement.style.scrollBehavior = 'smooth';
        lock = false;
    }
}

window.debounce = (func, wait, immediate)=> {
    let timeout;

    return function executedFunction() {
        const context = this;
        const args = arguments;

        const later = function () {
            timeout = null;
            if (!immediate) func.apply(context, args);
        };

        const callNow = immediate && !timeout;

        clearTimeout(timeout);

        timeout = setTimeout(later, wait);

        if (callNow) func.apply(context, args);
    };
};

const runOnResize = debounce(() => {
    if (document.body.clientWidth > 768 && lock) {
        header.invokeMethodAsync('ToggleHeaderState');
        header.invokeMethodAsync('Refresh');
    }
}, 250); 

window.addEventListener('resize', runOnResize);

window.setHeader = (dotNetHelper) => {
    header = dotNetHelper;
}
