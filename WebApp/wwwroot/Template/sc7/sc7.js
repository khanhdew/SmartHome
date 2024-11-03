// Quản lý các mục bên trong sidebar
const allSideMenu = document.querySelectorAll('#sidebar .side-menu.top li a');
const menuBar = document.querySelector('#content nav .bx.bx-menu');
const sidebar = document.getElementById('sidebar');

// Thêm lớp 'active' cho mục đang chọn trong sidebar
allSideMenu.forEach(item => {
    const li = item.parentElement;

    item.addEventListener('click', function () {
        allSideMenu.forEach(i => {
            i.parentElement.classList.remove('active');
        });
        li.classList.add('active');
    });
});

// Ẩn/hiện sidebar khi nhấn vào biểu tượng menu
menuBar.addEventListener('click', function () {
    sidebar.classList.toggle('hide');
});

// Kiểm tra kích thước màn hình để ẩn sidebar nếu cần
if (window.innerWidth < 768) {
    sidebar.classList.add('hide');
}

// Điều chỉnh hiển thị sidebar khi thay đổi kích thước cửa sổ
window.addEventListener('resize', function () {
    if (this.innerWidth > 576) {
        sidebar.classList.remove('hide');
    }
});

// Chức năng chuyển đổi chế độ tối (switch mode)
const switchMode = document.getElementById('switch-mode');
if (localStorage.getItem('darkMode') === 'enabled') {
    document.body.classList.add('dark');
    switchMode.checked = true;
}

// Thay đổi chế độ sáng/tối khi nhấn vào switch
switchMode.addEventListener('change', function () {
    if (this.checked) {
        document.body.classList.add('dark');
        localStorage.setItem('darkMode', 'enabled');
    } else {
        document.body.classList.remove('dark');
        localStorage.setItem('darkMode', 'disabled');
    }
});

// Cập nhật lại giao diện khi nhấn vào tài khoản để hiện/ẩn menu tài khoản
const accountBtn = document.getElementById('account-btn');
const accountMenu = document.getElementById('account-menu');

accountBtn.addEventListener('click', () => {
    accountMenu.classList.toggle('show');
});

// Ẩn menu tài khoản khi nhấp ra ngoài khu vực menu
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
//sua
const sua=document.getElementById("edit");
const suaBtnForm=document.getElementById("suaBtnForm");
const addForm2=document.getElementById('EditAll');

sua.addEventListener('click',()=>{
    suaBtnForm.style.display='block';
})
closeModal.addEventListener('click', () => {
    addModal.style.display = 'none'; 
});
window.addEventListener('click',(event2)=>{
    if(event2.target==suaBtnForm){
        suaBtnForm.display='none';
    }
})

//nút xóa

// Xử lý sự kiện khi nhấn nút Sửa và Xóa
document.addEventListener('click', function (event) {
    if (event.target.textContent === 'Xóa') {
        // Xóa mục
        const itemToDelete = event.target.closest('li');
        itemToDelete.remove();
    } 
});

//nút sửa





//Fan

$(document).ready(function() {
    let currentSpeed = 0.8; 

    $(".on").click(function() {
        $(".box img").css({
            "animation": `rotateon ${currentSpeed}s infinite linear`
        });

        $(".on").hide();
        $(".off").show();

        $(".on").css("box-shadow", "0px 0px 20px 5px green");
        $(".off").css("box-shadow", "0px 0px 20px 5px red");
    });

    $(".off").click(function() {
        // Dừng quay quạt
        $(".box img").css({
            "animation": "none" 
        });

        $(".on").show();
        $(".off").hide();

        $(".on").css("box-shadow", "0px 0px 20px 5px green");
        $(".off").css("box-shadow", "0px 0px 20px 5px red");
    });
    // Xử lý sự kiện khi nhấn vào các nút điều chỉnh tốc độ quạt
    $(".speed-button").click(function() {
        currentSpeed = $(this).data("speed");
        if ($(".off").is(":visible")) {

            $(".box img").css({
                "animation": `rotateon ${currentSpeed}s infinite linear`
            });
        }
    });


});





$(document).ready(function() {
    let isOn = false; 

    $('#color-picker').on('input', function() {
        const color = $(this).val();
        if (isOn) { 
            $('.rgb-color').css('background-color', color);
        }
    });

    $('#toggle-button').on('click', function() {
        isOn = !isOn; 
        if (isOn) {
            $('.rgb-color').css('background-color', $('#color-picker').val());
            $(this).text('Tắt'); 
        } else {
            $('.rgb-color').css('background-color', 'transparent');
            $(this).text('Bật'); 
        }
    });
});


