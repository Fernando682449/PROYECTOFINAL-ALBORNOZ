import { useState, useEffect } from "react";

export function Ofertas() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/Ofertas')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_publicacion: new Date(dato.fecha_publicacion)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de Ofertas:", error));
    }, []);

    return (
        <div>
            <h1>Listado de Ofertas</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID Oferta</th>
                        <th>ID Asociado</th>
                        <th>Título</th>
                        <th>Descripción</th>
                        <th>Fecha Publicación</th>
                        <th>Estado</th>
                        <th>Tipo Oferta</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_oferta}>
                            <td>{dato.id_oferta}</td>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.titulo}</td>
                            <td>{dato.descripcion}</td>
                            <td>{dato.fecha_publicacion.toLocaleDateString()}</td>
                            <td>{dato.estado}</td>
                            <td>{dato.tipo_oferta}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
