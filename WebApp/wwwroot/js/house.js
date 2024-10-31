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
    localStorage.setItem('sidebarState', sidebar.classList.contains('hide') ? 'hide' : 'show');
});

// Kiểm tra kích thước màn hình để ẩn sidebar nếu cần
if (window.innerWidth < 768) {
    sidebar.classList.add('hide');
    localStorage.setItem('sidebarState', 'hide');
}

// Điều chỉnh hiển thị sidebar khi thay đổi kích thước cửa sổ
window.addEventListener('resize', function () {
    if (this.innerWidth > 576) {
        sidebar.classList.remove('hide');
        localStorage.setItem('sidebarState', 'show');
    }
});

// Kiểm tra trạng thái sidebar từ localStorage khi tải trang
document.addEventListener('DOMContentLoaded', function () {
    const sidebar = document.getElementById('sidebar');
    const sidebarState = localStorage.getItem('sidebarState');

    // Add a class to disable the animation
    sidebar.classList.add('no-transition');

    if (sidebarState === 'hide') {
        sidebar.classList.add('hide');
    } else {
        sidebar.classList.remove('hide');
    }

    // Remove the class after the initial state is set
    setTimeout(() => {
        sidebar.classList.remove('no-transition');
    }, 0);
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
window.addEventListener('click', function (event) {
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

//nút sửa xóa

// Biến để theo dõi mục hiện tại đang được sửa
let currentItemToEdit = null;

// Xử lý sự kiện khi nhấn nút Sửa và Xóa
document.addEventListener('click', function (event) {
    if (event.target.textContent === 'Xóa') {
        // Xóa mục
        const itemToDelete = event.target.closest('li');
        itemToDelete.remove();
    } else if (event.target.textContent === 'Sửa') {
        // Lưu mục hiện tại để sửa
        currentItemToEdit = event.target.closest('li');
        const name = currentItemToEdit.querySelector('h3').textContent;
        const info = currentItemToEdit.querySelector('p').textContent;

        // Hiển thị modal và đặt các giá trị vào các trường input
        addModal.style.display = 'block';
        document.getElementById('Name').value = name;
        document.getElementById('Info').value = info;
    }
});

// // Cập nhật dữ liệu khi người dùng nhấn "Lưu"
// addForm.addEventListener('submit', (event) => {
//     event.preventDefault();
//
//     if (currentItemToEdit) {
//         // Cập nhật thông tin của mục đang sửa
//         currentItemToEdit.querySelector('h3').textContent = document.getElementById('Name').value;
//         currentItemToEdit.querySelector('p').textContent = document.getElementById('Info').value;
//
//         // Đặt lại biến `currentItemToEdit` về `null` sau khi cập nhật
//         currentItemToEdit = null;
//     }
//
//     // Đóng modal và đặt lại form
//     addModal.style.display = 'none';
//     addForm.reset();
// });
document.addEventListener('DOMContentLoaded', function () {
    const editButtons = document.querySelectorAll('.editBtn');
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


//nút xóa
    document.addEventListener('click', function (event) {
        if (event.target.textContent === 'Xóa') {
            const itemToDelete = event.target.closest('li');
            itemToDelete.remove();
        }
    });

//nút sửa

    document.addEventListener('DOMContentLoaded', () => {
        const editButtons = document.querySelectorAll('#edit');
        const choiceModal = document.getElementById('choiceModal');
        const editModal = document.getElementById('editModal');
        const membersModal = document.getElementById('membersModal');
        const editMemberModal = document.getElementById('editMemberModal');
        const closeButtons = document.querySelectorAll('.close');
        const editInfoForm = document.getElementById('editInfoForm');
        const editMemberForm = document.getElementById('editMemberForm');
        const membersList = document.getElementById('membersList');

        let currentEditing;
        let currentMember;
        editButtons.forEach(button => {
            button.addEventListener('click', (e) => {
                e.preventDefault();
                currentEditing = e.target.closest('li');
                choiceModal.style.display = 'block';
            });
        });

        document.getElementById('editChoice').addEventListener('click', () => {
            choiceModal.style.display = 'none';

            const name = currentEditing.querySelector('h3').innerText;
            const info = currentEditing.querySelector('p').innerText;

            document.getElementById('EditName').value = name;
            document.getElementById('EditInfo').value = info;

            editModal.style.display = 'block';
        });

        document.getElementById('membersChoice').addEventListener('click', () => {
            choiceModal.style.display = 'none';
            membersModal.style.display = 'block';
        });

        editInfoForm.addEventListener('submit', (e) => {
            e.preventDefault();
            const name = document.getElementById('EditName').value;
            const info = document.getElementById('EditInfo').value;

            currentEditing.querySelector('h3').innerText = name;
            currentEditing.querySelector('p').innerText = info;

            editModal.style.display = 'none';
        });

        membersList.addEventListener('click', (e) => {
            if (e.target.classList.contains('editMember')) {
                currentMember = e.target.closest('li');
                const memberName = currentMember.querySelector('span').innerText;

                document.getElementById('memberName').value = memberName;
                editMemberModal.style.display = 'block';
            }
        });

        editMemberForm.addEventListener('submit', (e) => {
            e.preventDefault();
            const name = document.getElementById('memberName').value;
            const info = document.getElementById('memberInfo').value;
            currentMember.querySelector('span').innerText = name;
            editMemberModal.style.display = 'none';
        });

        membersList.addEventListener('click', (e) => {
            if (e.target.classList.contains('deleteMember')) {
                e.target.closest('li').remove();
            }
        });

        closeButtons.forEach(button => {
            button.addEventListener('click', () => {
                editModal.style.display = 'none';
                membersModal.style.display = 'none';
                choiceModal.style.display = 'none';
                editMemberModal.style.display = 'none';
            });
        });

        window.addEventListener('click', (event) => {
            if (event.target === editModal || event.target === membersModal || event.target === choiceModal || event.target === editMemberModal) {
                editModal.style.display = 'none';
                membersModal.style.display = 'none';
                choiceModal.style.display = 'none';
                editMemberModal.style.display = 'none';
            }
        });
    });

//Fan

    $(document).ready(function () {
        let currentSpeed = 0.8;

        // Xử lý sự kiện khi nhấn nút ON
        $(".on").click(function () {
            // Bắt đầu quay quạt với tốc độ hiện tại
            $(".box img").css({
                "animation": `rotateon ${currentSpeed}s infinite linear`
            });

            // Ẩn nút ON và hiển thị nút OFF
            $(".on").hide();
            $(".off").show();

            // Cập nhật bóng đổ cho nút ON và OFF
            $(".on").css("box-shadow", "0px 0px 20px 5px green");
            $(".off").css("box-shadow", "0px 0px 20px 5px red");
        });

        // Xử lý sự kiện khi nhấn nút OFF
        $(".off").click(function () {
            // Dừng quay quạt
            $(".box img").css({
                "animation": "none"
            });

            // Hiển thị nút ON và ẩn nút OFF
            $(".on").show();
            $(".off").hide();

            // Cập nhật bóng đổ cho nút ON và OFF
            $(".on").css("box-shadow", "0px 0px 20px 5px green");
            $(".off").css("box-shadow", "0px 0px 20px 5px red");
        });

        // Xử lý sự kiện khi nhấn vào các nút điều chỉnh tốc độ quạt
        $(".speed-button").click(function () {
            // Lấy tốc độ từ thuộc tính data-speed của nút
            currentSpeed = $(this).data("speed");

            // Kiểm tra nếu quạt đang quay (nút OFF đang hiển thị)
            if ($(".off").is(":visible")) {
                // Cập nhật tốc độ quay của quạt
                $(".box img").css({
                    "animation": `rotateon ${currentSpeed}s infinite linear`
                });
            }
        });


    });


//RGB

    $(document).ready(function () {
        let isOn = false;

        $('#color-picker').on('input', function () {
            const color = $(this).val();
            if (isOn) {
                $('.rgb-color').css('background-color', color);
            }
        });

        $('#toggle-button').on('click', function () {
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


// History
    function addHistory(action) {
        const historyList = document.getElementById('historyList');
        const listItem = document.createElement('li');
        const timestamp = new Date().toLocaleString();
        listItem.textContent = `${timestamp}: ${action}`;
        historyList.appendChild(listItem);
    }

    document.getElementById('slider').addEventListener('input', function () {
        const brightness = this.value;
        addHistory(`Độ sáng đèn: ${brightness}`);
    });


    document.querySelector('.on').addEventListener('click', () => {
        addHistory("Bật quạt");
    });
    document.querySelector('.off').addEventListener('click', () => {
        addHistory("Tắt quạt");
    });
    document.querySelectorAll('.speed-button').forEach(button => {
        button.addEventListener('click', function () {
            const speed = this.getAttribute('data-speed');
            addHistory(`Tốc độ quạt: ${speed}`);
        });
    });


    document.getElementById('toggle-button').addEventListener('click', function () {
        const isOn = this.textContent === "Tắt";
        addHistory(isOn ? "Bật LED RGB" : "Tắt LED RGB");
    });
    document.getElementById('color-picker').addEventListener('input', function () {
        const color = this.value;
        addHistory(`Màu đèn LED RGB: ${color}`);
    });
})

