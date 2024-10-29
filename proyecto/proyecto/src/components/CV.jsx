import { useState, useEffect } from "react";

export function CV() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/CV')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_subida: new Date(dato.fecha_subida)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de CV:", error));
    }, []);

    return (
        <div>
            <h1>Listado de CV</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID CV</th>
                        <th>ID Asociado</th>
                        <th>Ruta CV</th>
                        <th>Fecha Subida</th>
                        <th>Experiencia Profesional</th>
                        <th>Educación</th>
                        <th>Habilidades</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_cv}>
                            <td>{dato.id_cv}</td>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.ruta_cv}</td>
                            <td>{dato.fecha_subida.toLocaleDateString()}</td>
                            <td>{dato.experiencia_profesional}</td>
                            <td>{dato.educacion}</td>
                            <td>{dato.habilidades}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
