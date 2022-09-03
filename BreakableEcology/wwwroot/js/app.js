"use strict";

let lock = false;
let header;
const headerId = 'header';

window.scrollLock = () => {
    if (!lock) {
        let pagePosition = window.scrollY;
        document.body.style.position = 'fixed';
        document.body.dataset.position = pagePosition;
        document.body.style.top = - pagePosition + 'px';
        document.body.style.width = 'calc(100% - 0.8em)';
        document.documentElement.style.scrollBehavior = 'auto';
        lock = true;
    }
}

window.scrollUnlock = () => {
    if (lock) {
        let pagePosition = parseInt(document.body.dataset.position, 10);
        document.body.style.position = '';
        document.body.style.top = '';
        document.body.style.width = 'unset';
        window.scrollTo({
            top: pagePosition,
            behavior: "auto"
        });
        document.documentElement.style.scrollBehavior = 'smooth';
        lock = false;
    }
}

window.debounce = (func, wait, immediate) => {
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

const runOnScroll = debounce(() => {
    if (document.body.clientWidth > 768) {
        const el = document.getElementById(headerId);
        if (pageYOffset > el.clientHeight) {
            document.querySelector('.on-top').classList.add('visible');
        } else {
            document.querySelector('.on-top').classList.remove('visible');
        }
    }
}, 250);

window.addEventListener('resize', runOnResize);
window.addEventListener('scroll', runOnScroll);

window.setHeader = (dotNetHelper) => {
    header = dotNetHelper;
}

window.scrollOnTop = (id) => {
    document.getElementById(id).scrollIntoView();
}

window.openDialog = (element) => {
    element.showModal();
}

window.closeDialog = (element) => {
    element.close();
}

window.setPasswordFocus = () => {
    document.getElementById('inputPassword').focus();
}

window.setTelephoneFocus = () => {
    document.getElementById('inputTelephone').focus();
}

window.setNameFocus = () => {
    document.getElementById('edit-name').focus();
}

window.setEditTelFocus = () => {
    document.getElementById('edit-tel').focus();
}

window.setEditPassFocus = () => {
    document.getElementById('edit-pass').focus();
}

window.setAddressFocus = () => {
    document.getElementById('edit-address').focus();
}