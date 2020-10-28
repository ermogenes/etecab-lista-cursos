using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using etecab_lista_cursos.Models;

namespace etecab_lista_cursos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursosController : ControllerBase
    {
        [HttpGet]
        public List<CursoModel> GetList()
        {
            var ListaDeCursos = new List<CursoModel>();

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/administracao/",
                nome = "Administração",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/desenvolvimento-de-sistemas/",
                nome = "Desenvolvimento de Sistemas",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/edificacoes/",
                nome = "Edificações",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/enfermagem/",
                nome = "Enfermagem",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/ensino-medio/",
                nome = "Ensino Médio",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/ensino-medio-com-habilitacao-profissional-de-tecnico-em-administracao-novotec-integrado/",
                nome = "Ensino Médio com Habilitação Técnica Profissional em Administração – Novotec",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/ensino-medio-com-habilitacao-profissional-de-tecnico-em-desenvolvimento-de-sistemas-novotec-integrado/",
                nome = "Ensino Médio com Habilitação Técnica Profissional em Desenvolvimento de Sistemas – Novotec",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/ensino-medio-linguagens-ciencias-humanas-e-sociais/",
                nome = "Ensino Médio – Linguagens, Ciências Humanas e Sociais",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/informatica-nova-matriz/",
                nome = "Informática",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/manutencao-e-suporte/",
                nome = "Manutenção e Suporte em Informática",
            });

            ListaDeCursos.Add(new CursoModel {
                url = "http://eteab.com.br/cms/index.php/turismo-receptivo/",
                nome = "Turismo Receptivo",
            });

            return ListaDeCursos;
        }
    }
}