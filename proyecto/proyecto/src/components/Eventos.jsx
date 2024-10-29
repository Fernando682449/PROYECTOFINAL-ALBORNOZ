import { useState, useEffect } from "react";

export function Eventos() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/Eventos')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_evento: new Date(dato.fecha_evento)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de Eventos:", error));
    }, []);

    return (
        <div>
            <h1>Listado de Eventos</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID Evento</th>
                        <th>ID Asociado</th>
                        <th>Nombre Evento</th>
                        <th>Fecha Evento</th>
                        <th>Descripción</th>
                        <th>Ubicación</th>
                        <th>Estado Evento</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_evento}>
                            <td>{dato.id_evento}</td>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.nombre_evento}</td>
                            <td>{dato.fecha_evento.toLocaleDateString()}</td>
                            <td>{dato.descripcion}</td>
                            <td>{dato.ubicacion}</td>
                            <td>{dato.estado_evento}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
