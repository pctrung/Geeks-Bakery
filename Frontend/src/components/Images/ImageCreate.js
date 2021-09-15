import { yupResolver } from "@hookform/resolvers/yup";
import { useState } from "react";
import { useFieldArray, useForm } from "react-hook-form";
import {
  Alert,
  Button,
  Card,
  CardBody,
  CardHeader,
  Col,
  Form,
  FormGroup,
  Row,
} from "reactstrap";
import * as yup from "yup";
import imageApi from "../../api/imageApi.js";

export default function ImageCreate(props) {
  const [stateMessage, setStateMessage] = useState({
    isOpen: false,
    color: "",
    message: "",
  });

  const schema = yup.object().shape({
    Images: yup.array().of(
      yup.object().shape({
        ImageFile: yup
          .mixed()
          .required()
          .test("fileFormat", "You can only upload image files", (value) => {
            if (typeof value !== "undefined") {
              if (value.length > 0) {
                var isValid = true;
                if (!value[0].type.includes("image")) {
                  isValid = false;
                }
                return isValid;
              }
            }
          }),
      }),
    ),
  });
  // react  hook form
  const {
    register,
    handleSubmit,
    formState: { errors },
    reset,
    control,
  } = useForm({
    resolver: yupResolver(schema),
  });
  const { fields, append, remove } = useFieldArray({
    control,
    name: "Images",
  });

  const onSubmit = async (content) => {
    var isUploadSuccess = true;
    if (content && props.cakeId) {
      if (content.Images?.length > 0) {
        content.Images.forEach(async (image) => {
          var uploadImage = new FormData();
          uploadImage.append("ImageFile", image.ImageFile[0]);
          uploadImage.append("CakeId", props.cakeId);
          uploadImage.append(
            "Caption",
            image.Caption ? image.Caption : "Cake Image",
          );
          uploadImage.append(
            "SortOrder",
            image.SortOrder ? image.SortOrder : 1,
          );
          uploadImage.append("IsDefault", image.IsDefault);

          var result = await imageApi.addAsync(uploadImage);
          if (!result) {
            isUploadSuccess = false;
          }
        });
      }
    }
    if (isUploadSuccess) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: "Add cake image successfully",
      });
      reset();
      await props.refreshPage(props.cakeId);
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Add cake image failed",
      });
    }
  };

  return (
    <>
      {/* Page content */}
      <Row className="mt-2">
        <Col className="mb-5 mb-xl-0" xl="12">
          <Card>
            <CardHeader>
              <Row>
                <div className="col d-flex justify-content-start align-items-center">
                  <h3 className="mb-0">Add more images</h3>

                  <Button
                    outline
                    className="ml-4"
                    color="danger"
                    onClick={() => remove(0)}
                    disabled={fields.length <= 0}
                  >
                    Remove
                  </Button>
                  <Button
                    outline
                    className="ml-2"
                    color="default"
                    onClick={() => append({ file: "" })}
                  >
                    Add
                  </Button>
                </div>
              </Row>
            </CardHeader>
            <Alert
              color={stateMessage.color}
              isOpen={stateMessage.isOpen}
              toggle={() => setStateMessage({ isOpen: false })}
            >
              {stateMessage.message}
            </Alert>
            <CardBody>
              <Form onSubmit={handleSubmit(onSubmit)}>
                <div className="pl-lg-4">
                  {fields.map((image, index) => (
                    <div key={image.id}>
                      <FormGroup>
                        <label className="form-control-label">
                          Image {index + 1}
                        </label>
                        <input
                          className="form-control"
                          type="file"
                          {...register(`Images.${index}.ImageFile`)}
                        />

                        <div
                          style={{ fontSize: 13 }}
                          className="text-danger fw-light mx-1 mt-2"
                        >
                          {typeof errors.Images !== "undefined"
                            ? errors.Images[index]?.ImageFile?.message
                            : ""}
                        </div>
                      </FormGroup>
                      <Row>
                        <Col lg="6">
                          <FormGroup>
                            <label className="form-control-label">
                              Caption (for alt image - SEO)
                            </label>
                            <input
                              className="form-control"
                              type="text"
                              placeholder="Ex: Chocolate Cake Image"
                              {...register(`Images.${index}.Caption`)}
                            />
                            <div
                              style={{ fontSize: 13 }}
                              className="text-danger fw-light mx-1 mt-2"
                            >
                              {typeof errors.Images !== "undefined"
                                ? errors.Images[index]?.Caption?.message
                                : ""}
                            </div>
                          </FormGroup>
                        </Col>
                        <Col lg="6">
                          <Row>
                            <FormGroup className="col-6">
                              <label className="form-control-label">
                                Sort order
                              </label>
                              <input
                                className="form-control"
                                type="number"
                                {...register(`Images.${index}.SortOrder`)}
                              />
                              <div
                                style={{ fontSize: 13 }}
                                className="text-danger fw-light mx-1 mt-2"
                              >
                                {typeof errors.Images !== "undefined"
                                  ? errors.Images[index]?.SortOrder?.message
                                  : ""}
                              </div>
                            </FormGroup>
                            <FormGroup className="col-6 d-flex flex-column align-items-start">
                              <label className="form-control-label">
                                Default Image
                              </label>
                              <label className="custom-toggle mt-2">
                                <input
                                  type="checkbox"
                                  {...register(`Images.${index}.IsDefault`)}
                                />
                                <span className="custom-toggle-slider rounded-circle"></span>
                              </label>
                              <div
                                style={{ fontSize: 13 }}
                                className="text-danger fw-light mx-1 mt-2"
                              >
                                {typeof errors.Images !== "undefined"
                                  ? errors.Images[index]?.IsDefault?.message
                                  : ""}
                              </div>
                            </FormGroup>
                          </Row>
                        </Col>
                      </Row>
                      <hr />
                    </div>
                  ))}
                  <FormGroup>
                    <Button
                      disabled={fields.length <= 0}
                      className={"float-right"}
                      color="success"
                    >
                      Save
                    </Button>
                  </FormGroup>
                </div>
              </Form>
            </CardBody>
          </Card>
        </Col>
      </Row>
    </>
  );
}
