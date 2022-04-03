
document.addEventListener('DOMContentLoaded', () => { 
  const toggleButton = document.querySelector('.toggle-nav');
  console.log(toggleButton);
  const nav = document.querySelector('.nav-items');
  toggleButton.addEventListener('click', () => {
   if(nav.getAttribute('data-visible') === 'false') {
     nav.setAttribute('data-visible', 'true');
     toggleButton.style.backgroundImage = 'url(/images/hamburger-open.png)';
     
    }else{
      nav.setAttribute('data-visible', 'false');
      toggleButton.style.backgroundImage = 'url(/images/close.png)';

   }
   
  });

});