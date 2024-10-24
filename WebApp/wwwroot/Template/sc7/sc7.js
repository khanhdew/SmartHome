const allSideMenu = document.querySelectorAll('#sidebar .side-menu.top li a');

allSideMenu.forEach(item=> {
	const li = item.parentElement;

	item.addEventListener('click', function () {
		allSideMenu.forEach(i=> {
			i.parentElement.classList.remove('active');
		})
		li.classList.add('active');
	})
});


// toggle sidebar
const menuBar = document.querySelector('#content nav .bx.bx-menu');
const sidebar = document.getElementById('sidebar');

menuBar.addEventListener('click', function () {
	sidebar.classList.toggle('hide');
})
// toggle menu
const accountBtn = document.getElementById('account-btn');
const accountMenu = document.getElementById('account-menu');

accountBtn.addEventListener('click', () => {
    accountMenu.classList.toggle('show');
});

window.addEventListener('click', function(event) {
    if (!event.target.matches('#account-btn, #account-btn *')) {
        accountMenu.classList.remove('show');
    }
});
//toggle add
const addBtn = document.getElementById('addBtn');
const addModal = document.getElementById('addModal');
const closeModal = document.querySelector('.close');
const addForm = document.getElementById('addForm');
const boxInfoList = document.getElementById('boxInfoList');

addBtn.addEventListener('click', () => {
    addModal.style.display = 'block'; 
});

closeModal.addEventListener('click', () => {
    addModal.style.display = 'none'; 
});

window.addEventListener('click', (event) => {
    if (event.target == addModal) {
        addModal.style.display = 'none';
    }
});

// lưu thông tin
addForm.addEventListener('submit', (event) => {
    event.preventDefault(); 
    const Name = document.getElementById('Name').value;
    const Info = document.getElementById('Info').value;

    const newItem = document.createElement('li');
    newItem.innerHTML = `
        <span class="text">
            <h3>${Name}</h3>
            <p>${Info}</p>
            <button>Sửa</button>
            <button>Xóa</button>
        </span>
    `;
    boxInfoList.appendChild(newItem); 

    addModal.style.display = 'none';

    addForm.reset();
});



//search
const searchButton = document.querySelector('#content nav form .form-input button');
const searchButtonIcon = document.querySelector('#content nav form .form-input button .bx');
const searchForm = document.querySelector('#content nav form');

searchButton.addEventListener('click', function (e) {
	if(window.innerWidth < 576) {
		e.preventDefault();
		searchForm.classList.toggle('show');
		if(searchForm.classList.contains('show')) {
			searchButtonIcon.classList.replace('bx-search', 'bx-x');
		} else {
			searchButtonIcon.classList.replace('bx-x', 'bx-search');
		}
	}
})


if(window.innerWidth < 768) {
	sidebar.classList.add('hide');
} else if(window.innerWidth > 576) {
	searchButtonIcon.classList.replace('bx-x', 'bx-search');
	searchForm.classList.remove('show');
}


window.addEventListener('resize', function () {
	if(this.innerWidth > 576) {
		searchButtonIcon.classList.replace('bx-x', 'bx-search');
		searchForm.classList.remove('show');
	}
})


//mode
const switchMode = document.getElementById('switch-mode');

switchMode.addEventListener('change', function () {
	if(this.checked) {
		document.body.classList.add('dark');
	} else {
		document.body.classList.remove('dark');
	}
})



