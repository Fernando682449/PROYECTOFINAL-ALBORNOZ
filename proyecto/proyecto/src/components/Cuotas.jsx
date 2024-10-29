import { useState, useEffect } from "react";

export function Cuotas() {
    const [datos, setDatos] = useState([]);

    useEffect(() => {
        fetch('https://localhost:7169/api/Cuotas')
            .then(response => response.json())
            .then(data => {
                const datosConFechasCorregidas = data.map(dato => ({
                    ...dato,
                    fecha_pago: new Date(dato.fecha_pago)
                }));
                setDatos(datosConFechasCorregidas);
            })
            .catch(error => console.error("Error al obtener datos de Cuotas:", error));
    }, []);

    return (
        <div>
            <h1>Listado de Cuotas</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID Cuota</th>
                        <th>ID Asociado</th>
                        <th>Monto</th>
                        <th>Fecha Pago</th>
                        <th>Estado</th>
                        <th>Método Pago</th>
                    </tr>
                </thead>
                <tbody>
                    {datos.map(dato => (
                        <tr key={dato.id_cuota}>
                            <td>{dato.id_cuota}</td>
                            <td>{dato.id_asociado}</td>
                            <td>{dato.monto.toFixed(2)} €</td>
                            <td>{dato.fecha_pago.toLocaleDateString()}</td>
                            <td>{dato.estado}</td>
                            <td>{dato.metodo_pago}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}
