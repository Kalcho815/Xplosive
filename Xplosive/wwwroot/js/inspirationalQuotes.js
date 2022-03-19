const quoteParagraph = document.getElementById("quoteParagraph");
const quoteAuthor = document.getElementById("quoteAuthor");

window.onload =  function() {
    getQuote();

}

const getQuote = () => {
    quoteParagraph.innerHTML = "";
    quoteAuthor.innerHTML = "";
    quoteParagraph.classList.remove("fade-in");
    quoteAuthor.classList.remove("fade-in");
    fetch("https://api.quotable.io/random")
        .then(response => response.json())
        .then(data => {

            quoteParagraph.innerHTML = `-"${data.content}"`;
            quoteAuthor.innerHTML = `-"${data.author}"`;
            quoteParagraph.classList.add("fade-in");
            quoteAuthor.classList.add("fade-in");
        })
        .catch(error => console.log(error));

    setTimeout(getQuote, 10000);
}