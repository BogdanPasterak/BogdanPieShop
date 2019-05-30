// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    document.querySelectorAll('.my-button').forEach((btn) => {
        btn.addEventListener('click', (e) => {
            console.log(e.target);
            let btn = e.target;
            let long = btn.parentElement.querySelector('p');
            let short = btn.parentElement.querySelectorAll('p')[1];

            long.classList.toggle('d-none');
            short.classList.toggle('d-none');
            btn.classList.toggle('d-none');

        });
    });
    document.querySelectorAll('.my-desc').forEach((desc) => {
        desc.addEventListener('click', (e) => {
            console.log(e.target);
            let long = e.target;
            let btn = long.parentElement.querySelector('.my-button');
            let short = long.parentElement.querySelectorAll('p')[1];

            long.classList.toggle('d-none');
            short.classList.toggle('d-none');
            btn.classList.toggle('d-none');

        });
    });
});

