import { useState, useEffect } from "react";

export function Asociados() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/Asociados')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_nacimiento: new Date(dato.fecha_nacimiento)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de Asociados:", error));
    }, []);

    return (
        <div>
            <h1>Listado de Asociados</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID Asociado</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Fecha Nacimiento</th>
                        <th>Correo</th>
                        <th>Teléfono</th>
                        <th>Dirección</th>
                        <th>Estado Registro</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_asociado}>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.nombre}</td>
                            <td>{dato.apellido}</td>
                            <td>{dato.fecha_nacimiento.toLocaleDateString()}</td>
                            <td>{dato.correo}</td>
                            <td>{dato.telefono}</td>
                            <td>{dato.direccion}</td>
                            <td>{dato.estado_registro}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
