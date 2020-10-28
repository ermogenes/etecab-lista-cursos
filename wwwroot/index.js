const iniciar = async () => {
    const listaDeCursos = document.getElementById('lista-de-cursos');
    const response = await fetch('/Cursos');
    const result = await response.json();
    result.forEach(curso => {
        listaDeCursos.insertAdjacentHTML('beforeend',
            `<li><a href="${curso.url}">${curso.nome}</a></li>`
        );
    });
};

document.addEventListener('DOMContentLoaded', iniciar);