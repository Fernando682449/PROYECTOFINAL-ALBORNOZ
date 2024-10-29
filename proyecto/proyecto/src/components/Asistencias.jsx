import { useState, useEffect } from "react";

export function Asistencias() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/Asistencias')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_registro: new Date(dato.fecha_registro)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de Asistencias:", error));
    }, []);

    return (
        <div>
            <h1>Listado de Asistencias</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID Asistencia</th>
                        <th>ID Evento</th>
                        <th>ID Asociado</th>
                        <th>Confirmado</th>
                        <th>Fecha Registro</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_asistencia}>
                            <td>{dato.id_asistencia}</td>
                            <td>{dato.id_evento}</td>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.confirmado ? 'Sí' : 'No'}</td>
                            <td>{dato.fecha_registro.toLocaleDateString()}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
